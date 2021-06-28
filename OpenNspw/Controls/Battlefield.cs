using System;
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
			var center = (unit.GetComponent<Airplane>() is Airplane airplane && airplane.IsInHangar)
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

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Draw(e, Units);

			if (Subject is not null)
				DrawUnitPath(e, Subject);
		}

		private DPoint _previousMouseLocation;

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (e.Button == MouseButtons.Middle)
				_camera.Center += new WVec((_previousMouseLocation - (DSize)e.Location).ToXnaPoint().ToVector2()).FlipY(_camera.FlipY);

			_previousMouseLocation = e.Location;
		}

		protected override void OnSelectionRestored(EventArgs e)
		{
			base.OnSelectionRestored(e);

			_isQueued = false;
		}

		protected override void OnMapClick(EventArgs e)
		{
			base.OnMapClick(e);

			if (Subject is not null)
			{
				if (Subject.Components.OfType<Mobile>().SingleOrDefault() is Mobile mobile)
				{
					Assets.SoundEffects["SoundEffects/btn_4"].Play();

					_world.DispatchOrder(new WaypointOrder(
						SubjectId: mobile.Self.Id,
						SelectionIds: Selection.Units.Select(u => u.Id).ToArray(),
						Position: MouseWPos,
						IsQueued: _isQueued
					));

					_isQueued = true;

					if (mobile is Airplane airplane && airplane.IsInHangar)
						Selection.Clear();
				}
			}
		}
	}
}
