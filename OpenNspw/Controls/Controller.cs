using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using OpenNspw.Components;
using DColor = System.Drawing.Color;
using DPen = System.Drawing.Pen;
using DPoint = System.Drawing.Point;

namespace OpenNspw.Controls
{
	internal class Controller : Control
	{
		private readonly World _world;
		private readonly Camera _camera;

		public Selection Selection { get; }
		private Unit? _mouseOverUnit;
		private SelectionState _selectionState;

		public Controller(World world, Camera camera) : base()
		{
			_world = world;
			_camera = camera;

			Selection = world.Selection;
		}

		public event EventHandler? SelectionAdded;
		private void OnSelectionAdded(EventArgs e) => SelectionAdded?.Invoke(this, e);

		public event EventHandler? SelectionRemoved;
		private void OnSelectionRemoved(EventArgs e) => SelectionRemoved?.Invoke(this, e);

		public event EventHandler? SelectionCanceled;
		private void OnSelectionCanceled(EventArgs e) => SelectionCanceled?.Invoke(this, e);

		public event EventHandler? SelectionRestored;
		private void OnSelectionRestored(EventArgs e) => SelectionRestored?.Invoke(this, e);

		public event EventHandler? MapClick;
		protected virtual void OnMapClick(EventArgs e) => MapClick?.Invoke(this, e);

		private List<Unit> SelectedUnits => Selection.Units;

		public Unit? Subject => SelectedUnits.FirstOrDefault();

		public Unit? MouseFocusUnit
		{
			get => Selection.MouseFocusUnit;
			set => Selection.MouseFocusUnit = value;
		}

		protected DPoint MouseLocation
		{
			get
			{
				var viewportAdapter = ((MonoGameGraphicsFactory)WindowManager.GraphicsFactory).ViewportAdapter;
				var mousePosition = Mouse.GetState().Position;
				return (viewportAdapter?.PointToScreen(mousePosition) ?? mousePosition).ToDrawingPoint();
			}
		}

		protected WPos MouseWPos => _camera.ScreenToWorld(PointToClient(MouseLocation).ToXnaPoint().ToVector2());

		protected void Update(IEnumerable<Unit> units)
		{
			_mouseOverUnit = units.FirstOrDefault(u => WRect.FromCenter(u.Center, new WVec(40, 40)).Contains(MouseWPos));
		}

		protected void DrawBackground(PaintEventArgs e, IEnumerable<Unit> units)
		{
			foreach (var unit in units.Where(u => _camera.Viewport.Intersects(WRect.FromCenter(u.Center, new WVec(80, 80)))))
				unit.Draw(e.Graphics, _camera);
		}

		protected void Draw(PaintEventArgs e, IEnumerable<Unit> units)
		{
			if (_mouseOverUnit is not null)
			{
				if (_world.FrameCount % 2 != 0)
					e.Graphics.DrawRectangle(new DPen(DColor.White), _camera.WorldToScreen(WRect.FromCenter(_mouseOverUnit.Center, new WVec(50, 50))).ToRectangle().ToDrawingRectangle());
			}

			foreach (var unit in units.Intersect(SelectedUnits))
			{
				var size = (unit == Subject) ? new WVec(60, 60) : new WVec(40, 40);
				e.Graphics.DrawRectangle(new DPen(DColor.White), _camera.WorldToScreen(WRect.FromCenter(unit.Center, size)).ToRectangle().ToDrawingRectangle());
			}
		}

		private void AddSelectedUnit(Unit unit)
		{
			SelectedUnits.Add(unit);

			OnSelectionAdded(EventArgs.Empty);
		}

		private void RemoveSelectedUnit(Unit unit)
		{
			SelectedUnits.Remove(unit);

			OnSelectionRemoved(EventArgs.Empty);
		}

		public void UpdateSelection()
		{
			if (_mouseOverUnit is null)
				return;

			switch (_selectionState)
			{
				case SelectionState.Selecting:
					if (!SelectedUnits.Contains(_mouseOverUnit))
						AddSelectedUnit(_mouseOverUnit);
					break;

				case SelectionState.Unselecting:
					if (SelectedUnits.Contains(_mouseOverUnit) && _mouseOverUnit != Subject)
						RemoveSelectedUnit(_mouseOverUnit);
					break;
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (e.Button == MouseButtons.Left)
				UpdateSelection();
		}

		private void CancelSelection()
		{
			if (Subject is null)
				return;

			RemoveSelectedUnit(Subject);

			Selection.Clear();

			OnSelectionCanceled(EventArgs.Empty);
		}

		private void RestoreSelection(Unit? unit)
		{
			if (unit is null)
				return;

			AddSelectedUnit(unit);

			OnSelectionRestored(EventArgs.Empty);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (e.Button == MouseButtons.Left)
			{
				if (_mouseOverUnit is null)
				{
					if (_world.Map.Contains(MouseWPos))
						OnMapClick(EventArgs.Empty);
				}
				else
				{
					if (_mouseOverUnit == Subject)
						CancelSelection();
					else if (SelectedUnits.Contains(_mouseOverUnit))
					{
						_selectionState = SelectionState.Unselecting;

						RemoveSelectedUnit(_mouseOverUnit);
					}
					else
					{
						_selectionState = SelectionState.Selecting;

						if (SelectedUnits.Any())
							AddSelectedUnit(_mouseOverUnit);
						else
						{
							if (_mouseOverUnit?.GetComponent<Airplane>() is not Airplane airplane || !airplane.IsInHangar)
								MouseFocusUnit = _mouseOverUnit;

							RestoreSelection(_mouseOverUnit);
						}
					}
				}
			}

			if (e.Button == MouseButtons.Right)
			{
				if (SelectedUnits.Any())
					CancelSelection();
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
