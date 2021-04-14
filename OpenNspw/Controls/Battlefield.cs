using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using DColor = System.Drawing.Color;
using DPen = System.Drawing.Pen;
using DPoint = System.Drawing.Point;
using DSize = System.Drawing.Size;

namespace OpenNspw.Controls
{
	internal sealed class Battlefield : Control
	{
		private readonly World _world;
		private readonly Camera _camera;

		private readonly Selection _selection;
		private Unit? _mouseOverUnit;
		private SelectionState _selectionState;

		public Battlefield(World world, Camera camera)
		{
			_world = world;
			_camera = camera;

			_selection = world.Selection;
		}

		private List<Unit> SelectedUnits => _selection.Units;

		private Unit? Subject => SelectedUnits.FirstOrDefault();

		private Unit? MouseFocusUnit
		{
			get => _selection.MouseFocusUnit;
			set => _selection.MouseFocusUnit = value;
		}

		private DPoint MouseLocation
		{
			get
			{
				var viewportAdapter = ((MonoGameGraphicsFactory)WindowManager.GraphicsFactory).ViewportAdapter;
				var mousePosition = Mouse.GetState().Position;
				return (viewportAdapter?.PointToScreen(mousePosition) ?? mousePosition).ToDrawingPoint();
			}
		}

		public void Update()
		{
			var mouseWPos = _camera.ScreenToWorld(PointToClient(MouseLocation).ToXnaPoint().ToVector2());
			_mouseOverUnit = _world.Units.FirstOrDefault(u => WRect.FromCenter(u.Center, new WVec(40, 40)).Contains(mouseWPos));
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			_world.Draw(e.Graphics, _camera);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (_mouseOverUnit is not null)
			{
				if (_world.FrameCount % 2 != 0)
					e.Graphics.DrawRectangle(new DPen(DColor.White), _camera.WorldToScreen(WRect.FromCenter(_mouseOverUnit.Center, new WVec(50, 50))).ToRectangle().ToDrawingRectangle());
			}

			foreach (var unit in _world.Units.Intersect(SelectedUnits))
			{
				var size = (unit == Subject) ? new WVec(60, 60) : new WVec(40, 40);
				e.Graphics.DrawRectangle(new DPen(DColor.White), _camera.WorldToScreen(WRect.FromCenter(unit.Center, size)).ToRectangle().ToDrawingRectangle());
			}

			if (Subject is not null)
			{
				var control = WindowManager.WindowFromPoint(MouseLocation);
				if (((control is null || control == this) && WindowManager.Capture is null) || Capture)
				{
					var mouseWPos = _camera.ScreenToWorld(PointToClient(MouseLocation).ToXnaPoint().ToVector2());
					e.Graphics.DrawLine(new DPen(DColor.White), _camera.WorldToScreen(Subject.Center).ToPoint().ToDrawingPoint(), _camera.WorldToScreen(mouseWPos).ToPoint().ToDrawingPoint());
				}
			}
		}

		public void UpdateSelection()
		{
			if (_mouseOverUnit is null)
				return;

			switch (_selectionState)
			{
				case SelectionState.Selecting:
					if (!SelectedUnits.Contains(_mouseOverUnit))
					{
						Assets.SoundEffects["SoundEffects/btn_1"].Play();
						SelectedUnits.Add(_mouseOverUnit);
					}
					break;

				case SelectionState.Unselecting:
					if (SelectedUnits.Contains(_mouseOverUnit) && _mouseOverUnit != Subject)
					{
						Assets.SoundEffects["SoundEffects/btn_2"].Play();
						SelectedUnits.Remove(_mouseOverUnit);
					}
					break;
			}
		}

		private DPoint _previousMouseLocation;

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (e.Button == MouseButtons.Left)
				UpdateSelection();

			if (e.Button == MouseButtons.Middle)
				_camera.Center += new WVec((_previousMouseLocation - (DSize)e.Location).ToXnaPoint().ToVector2()).FlipY(_camera.FlipY);

			_previousMouseLocation = e.Location;
		}

		private void CancelSelection() => _selection.Clear();

		private void RestoreSelection(Unit? unit)
		{
			if (unit is null)
				return;

			Assets.SoundEffects["SoundEffects/btn_1"].Play();
			SelectedUnits.Add(unit);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (e.Button == MouseButtons.Left)
			{
				if (_mouseOverUnit is not null)
				{
					if (_mouseOverUnit == Subject)
					{
						Assets.SoundEffects["SoundEffects/btn_2"].Play();
						CancelSelection();
					}
					else if (SelectedUnits.Contains(_mouseOverUnit))
					{
						Assets.SoundEffects["SoundEffects/btn_2"].Play();
						_selectionState = SelectionState.Unselecting;
						SelectedUnits.Remove(_mouseOverUnit);
					}
					else
					{
						_selectionState = SelectionState.Selecting;

						if (SelectedUnits.Any())
						{
							Assets.SoundEffects["SoundEffects/btn_1"].Play();
							_selection.Units.Add(_mouseOverUnit);
						}
						else
						{
							MouseFocusUnit = _mouseOverUnit;

							RestoreSelection(_mouseOverUnit);
						}
					}
				}
			}

			if (e.Button == MouseButtons.Right)
			{
				if (SelectedUnits.Any())
				{
					Assets.SoundEffects["SoundEffects/btn_2"].Play();
					CancelSelection();
				}
				else
					RestoreSelection(MouseFocusUnit);
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			if (e.Button == MouseButtons.Left)
				_selectionState = SelectionState.None;
		}
	}
}
