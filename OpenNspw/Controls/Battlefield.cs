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

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			Draw(e, Units);

			if (Subject is not null)
			{
				var control = WindowManager.WindowFromPoint(MouseLocation);
				if (((control is null || control == this) && WindowManager.Capture is null) || Capture)
				{
					var center = (Subject.GetComponent<Airplane>() is Airplane airplane && airplane.IsInHangar)
						? airplane.Hangar.Self.Center
						: Subject.Center;
					e.Graphics.DrawLine(new DPen(DColor.White), _camera.WorldToScreen(center).ToPoint().ToDrawingPoint(), _camera.WorldToScreen(MouseWPos).ToPoint().ToDrawingPoint());
				}
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

		protected override void OnMapClick(EventArgs e)
		{
			base.OnMapClick(e);

			if (Subject is not null)
			{
				_world.DispatchOrder(new WaypointOrder(
					SubjectId: Subject.Id,
					SelectionIds: Selection.Units.Select(u => u.Id).ToArray(),
					Position: MouseWPos,
					IsQueued: Selection.IsQueued
				));
			}
		}
	}
}
