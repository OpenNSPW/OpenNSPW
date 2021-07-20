﻿using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using OpenNspw.Components;
using OpenNspw.Orders;
using DColor = System.Drawing.Color;
using DPen = System.Drawing.Pen;
using DPoint = System.Drawing.Point;
using DSize = System.Drawing.Size;

namespace OpenNspw.Controls
{
	internal sealed class Battlefield : Controller
	{
		private readonly World _world;
		private readonly Camera _camera;

		private bool _isQueued;

		public Battlefield(World world, Camera camera) : base(world, camera)
		{
			_world = world;
			_camera = camera;
		}

		private static bool CanDispatchLandingCellOrder(Transport transport, WPos position) =>
			transport.CanLand(position) && WRect.FromCenter(transport.Self.World.Map.CenterOfCell(position), new WVec(40, 40)).Contains(position);

		private static bool CanDispatchWaypointOrder(Mobile mobile) => mobile switch
		{
			Airplane airplane => !(airplane.IsInHangar && !airplane.CanTakeOff),
			Ship => true,
			_ => throw new InvalidOperationException(),
		};

		private IEnumerable<Unit> Units => _world.Units;

		public void Update()
		{
			Update(Units);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			_world.Draw(e.Graphics, _camera);

			DrawBackground(e, Units);
		}

		private void DrawUnitPath(PaintEventArgs e, Unit unit)
		{
			var center = (unit.TryGetComponent<Airplane>(out var airplane) && airplane.IsInHangar)
				? airplane.Hangar.Self.Center
				: unit.Center;
			var previousWaypoint = center;
			foreach (var waypoint in unit.Waypoints)
			{
				DrawLine(e, new DPen(DColor.White), previousWaypoint, waypoint);
				DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(waypoint, new WVec(20, 20)));
				previousWaypoint = waypoint;
			}

			var control = WindowManager.WindowFromPoint(MouseLocation);
			if (((control is null || control == this) && WindowManager.Capture is null) || Capture)
				DrawLine(e, new DPen(DColor.White), Selection.IsQueued ? unit.Waypoints.Last() : center, MouseWPos);
		}

		private void DrawArrow(PaintEventArgs e, Unit unit, WPos targetPosition)
		{
			var angle = WAngle.FromVector(targetPosition - unit.Center);
			var point = unit.Center + angle.ToVector(40);
			DrawLine(e, new DPen(DColor.White), point, unit.Center + (angle - WAngle.FromDegrees(10)).ToVector(20));
			DrawLine(e, new DPen(DColor.White), point, unit.Center + (angle - WAngle.FromDegrees(350)).ToVector(20));
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Draw(e, Units);

			if (Subject is not null)
			{
				if (Subject.TryGetComponent<Transport>(out var transport))
				{
					if (CanDispatchLandingCellOrder(transport, MouseWPos))
					{
						if (_world.FrameCount % 2 != 0)
							DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(_world.Map.CenterOfCell(MouseWPos), new WVec(50, 50)));
					}

					if (transport.LandingCell is CPos landingCell)
					{
						var margin = 10 + _world.FrameCount % 8 * 2;
						DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(_world.Map.CenterOfCell(landingCell), new WVec(80 - margin * 2, 80 - margin * 2)));
					}
				}

				if (Subject.TryGetComponent<Armament>(out var armament))
				{
					if (armament.Target is Unit target && target.CanBeViewedBy(_world.LocalPlayer))
					{
						var margin = 10 + _world.FrameCount % 8 * 2;
						DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(target.Center, new WVec(80 - margin * 2, 80 - margin * 2)));
					}
				}

				DrawUnitPath(e, Subject);
			}

			foreach (var unit in _world.Units.Where(u => u.Owner == _world.LocalPlayer))
			{
				if (unit.GetComponent<Armament>()?.Target is Unit target)
				{
					if (target.CanBeViewedBy(_world.LocalPlayer))
						DrawArrow(e, unit, targetPosition: target.Center);
					else
					{
						DrawLine(e, new DPen(DColor.White), unit.Center + new WVec(30, 40), unit.Center + new WVec(10, 20));
						DrawLine(e, new DPen(DColor.White), unit.Center + new WVec(10, 40), unit.Center + new WVec(30, 20));
					}
				}

				if (unit.GetComponent<Transport>()?.LandingCell is CPos landingCell)
					DrawArrow(e, unit, targetPosition: _world.Map.CenterOfCell(landingCell));
			}
		}

		private DPoint _previousMouseLocation;

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (e.Button == MouseButtons.Middle)
				_camera.Center += new WVec((_previousMouseLocation - (DSize)e.Location).ToXnaPoint().ToVector2()).FlipY(_camera.FlipY);

			_previousMouseLocation = e.Location;
		}

		private IUnitOrder? GenerateUnitOrder(Unit subject)
		{
			if (MouseOverUnit is null)
			{
				if (subject.TryGetComponent<Transport>(out var transport) && CanDispatchLandingCellOrder(transport, MouseWPos))
				{
					var newLandingCell = _world.Map.CellContaining(MouseWPos);
					var canceled = transport.LandingCell == newLandingCell;

					return new LandingCellOrder(
						subject.Id,
						canceled ? null : newLandingCell
					);
				}

				if (subject.Components.OfType<Mobile>().SingleOrDefault() is Mobile mobile && CanDispatchWaypointOrder(mobile))
				{
					return new WaypointOrder(
						subject.Id,
						Selection.ToArray(),
						MouseWPos,
						_isQueued
					);
				}
			}
			else
			{
				if (subject.TryGetComponent<Armament>(out var armament) && !CanSelect(MouseOverUnit))
				{
					var canceled = armament?.Target == MouseOverUnit;

					return new TargetOrder(
						subject.Id,
						Selection.ToArray(),
						canceled ? null : MouseOverUnit.Id
					);
				}
			}

			return null;
		}

		private void DispatchUnitOrder(Unit subject, IUnitOrder unitOrder)
		{
			_world.DispatchOrder(unitOrder);

			switch (unitOrder)
			{
				case LandingCellOrder landingCellOrder:
					if (landingCellOrder.LandingCell is null)
						_world.Sound.Play("SoundEffects/btn_6");
					else
						_world.Sound.Play("SoundEffects/btn_3");
					break;

				case WaypointOrder:
					_world.Sound.Play("SoundEffects/btn_4");

					_isQueued = true;

					if (subject.GetComponent<Airplane>()?.IsInHangar == true)
						Selection.Clear();
					break;

				case TargetOrder targetOrder:
					if (targetOrder.TargetId is null)
						_world.Sound.Play("SoundEffects/btn_6");
					else
						_world.Sound.Play("SoundEffects/btn_3");
					break;
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (e.Button == MouseButtons.Left)
			{
				if (Subject is not null)
				{
					var unitOrder = GenerateUnitOrder(Subject);
					if (unitOrder is not null)
						DispatchUnitOrder(Subject, unitOrder);
				}
			}
		}

		protected override void OnSelectionRestored(EventArgs e)
		{
			base.OnSelectionRestored(e);

			_isQueued = false;
		}
	}
}
