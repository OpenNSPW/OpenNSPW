using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using OpenNspw.Activities;
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

		public bool IsQueued { get; set; }

		public Battlefield(World world, Camera camera) : base(world, camera)
		{
			_world = world;
			_camera = camera;
		}

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

			if (unit.CurrentActivity is Evade evade && evade.IsMoving)
				DrawLine(e, new DPen(DColor.Red), unit.Center, evade.Destination);
		}

		private void DrawArrow(PaintEventArgs e, Unit unit, WPos targetPosition)
		{
			var angle = WAngle.FromVector(targetPosition - unit.Center);
			var point = unit.Center + angle.ToVector(40);
			DrawLine(e, new DPen(DColor.White), point, unit.Center + (angle - WAngle.FromDegrees(10)).ToVector(20));
			DrawLine(e, new DPen(DColor.White), point, unit.Center + (angle - WAngle.FromDegrees(350)).ToVector(20));
		}

		private static IUnitOrder? GenerateUnitOrderCore(Unit self, Unit? target, WPos position, bool isQueued) =>
			self.Components.OfType<IOrderDispatcher>()
				.SelectMany(orderDispatcher => orderDispatcher.OrderTargeters.Select(orderTargeter => (OrderDispatcher: orderDispatcher, OrderTargeter: orderTargeter)))
				.OrderByDescending(x => x.OrderTargeter.Priority)
				.Where(x => x.OrderTargeter.CanTarget(self, target, position))
				.Select(x => x.OrderDispatcher.DispatchOrder(self, x.OrderTargeter, target, position, isQueued))
				.WhereNotNull()
				.FirstOrDefault();

		private static IUnitOrder? GenerateUnitOrder(Unit self, Unit? target, WPos position, bool isQueued) =>
			GenerateUnitOrderCore(self, target, position, isQueued) ?? GenerateUnitOrderCore(self, target: null, position, isQueued);

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Draw(e, Units);

			if (Subject is not null)
			{
				if (MouseOverUnit is null || !Subject.CanSelect(MouseOverUnit))
				{
					var unitOrder = GenerateUnitOrder(Subject, MouseOverUnit, MouseWPos, IsQueued);
					switch (unitOrder)
					{
						case TargetOrder when MouseOverUnit is not null:
							if (_world.FrameCount % 2 != 0)
								DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(MouseOverUnit.Center, new WVec(50, 50)));
							break;

						case LandingCellOrder landingCellOrder when landingCellOrder.LandingCell is not null:
							if (_world.FrameCount % 2 != 0)
								DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(_world.Map.CenterOfCell(landingCellOrder.LandingCell.Value), new WVec(50, 50)));
							break;
					}
				}

				if (Subject.TryGetComponent<Airplane>(out var airplane))
				{
					if (!airplane.IsInHangar && airplane.Hangar is Hangar hangar)
					{
						var rect = WRect.FromCenter(hangar.Self.Center, new WVec(80, 80));
						var point1 = rect.BottomLeft + new WVec(19, -15).FlipY(_camera.FlipY);
						var point2 = rect.BottomRight + new WVec(-19, -15).FlipY(_camera.FlipY);
						DrawLine(e, new DPen(DColor.White), point1, point2);
						DrawLine(e, new DPen(DColor.White), point1 + new WVec(0, 2).FlipY(_camera.FlipY), point2 + new WVec(0, 2).FlipY(_camera.FlipY));
					}
				}

				if (Subject.TryGetComponent<Transport>(out var transport))
				{
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

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (e.Button == MouseButtons.Left)
			{
				if (Subject is not null)
				{
					if (MouseOverUnit is null || !Subject.CanSelect(MouseOverUnit))
					{
						var unitOrder = GenerateUnitOrder(Subject, MouseOverUnit, MouseWPos, IsQueued);
						if (unitOrder is not null)
						{
							_world.PlaySoundForUnitOrder(unitOrder);
							_world.DispatchOrder(unitOrder);

							if (unitOrder is WaypointOrder)
							{
								IsQueued = true;

								if (unitOrder.Subject.GetComponent<Airplane>()?.IsInHangar == true)
									Selection.Clear();
							}
						}
					}
				}
			}
		}
	}
}
