using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
		public Unit? MouseOverUnit { get; private set; }
		private SelectionState _selectionState;

		public Controller(World world, Camera camera) : base()
		{
			_world = world;
			_camera = camera;

			Selection = world.Selection;
		}

		public event EventHandler? SelectionAdded;
		protected virtual void OnSelectionAdded(EventArgs e) => SelectionAdded?.Invoke(this, e);

		public event EventHandler? SelectionRemoved;
		protected virtual void OnSelectionRemoved(EventArgs e) => SelectionRemoved?.Invoke(this, e);

		public event EventHandler? SelectionCanceled;
		protected virtual void OnSelectionCanceled(EventArgs e) => SelectionCanceled?.Invoke(this, e);

		public event EventHandler? SelectionRestored;
		protected virtual void OnSelectionRestored(EventArgs e) => SelectionRestored?.Invoke(this, e);

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

		private bool CanMouseOver(Unit unit)
		{
			return true;
		}

		protected bool CanSelect(Unit unit)
		{
			if (unit.Owner != _world.LocalPlayer)
				return false;

			return CanMouseOver(unit);
		}

		protected void Update(IEnumerable<Unit> units)
		{
			MouseOverUnit = units.FirstOrDefault(u => WRect.FromCenter(u.Center, new WVec(40, 40)).Contains(MouseWPos) && CanMouseOver(u));
		}

		protected void DrawLine(PaintEventArgs e, DPen pen, WPos point1, WPos point2)
		{
			e.Graphics.DrawLine(pen, _camera.WorldToScreen(point1).ToPoint().ToDrawingPoint(), _camera.WorldToScreen(point2).ToPoint().ToDrawingPoint());
		}

		protected void DrawRectangle(PaintEventArgs e, DPen pen, WRect rectangle)
		{
			e.Graphics.DrawRectangle(pen, ((Rectangle)_camera.WorldToScreen(rectangle)).ToDrawingRectangle());
		}

		protected void DrawBackground(PaintEventArgs e, IEnumerable<Unit> units)
		{
			foreach (var unit in units.Where(u => _camera.Viewport.Intersects(WRect.FromCenter(u.Center, new WVec(80, 80)))))
				unit.Draw(e.Graphics, _camera);
		}

		protected void Draw(PaintEventArgs e, IEnumerable<Unit> units)
		{
			if (MouseOverUnit is not null)
			{
				if (_world.FrameCount % 2 != 0)
					DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(MouseOverUnit.Center, new WVec(50, 50)));
			}

			foreach (var unit in units.Intersect(SelectedUnits))
			{
				var size = (unit == Subject) ? new WVec(60, 60) : new WVec(40, 40);
				DrawRectangle(e, new DPen(DColor.White), WRect.FromCenter(unit.Center, size));
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
			if (MouseOverUnit is null)
				return;

			switch (_selectionState)
			{
				case SelectionState.Selecting:
					if (!SelectedUnits.Contains(MouseOverUnit))
						AddSelectedUnit(MouseOverUnit);
					break;

				case SelectionState.Unselecting:
					if (SelectedUnits.Contains(MouseOverUnit) && MouseOverUnit != Subject)
						RemoveSelectedUnit(MouseOverUnit);
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
			if (unit is null || !CanSelect(unit))
				return;

			Selection.Clear();

			AddSelectedUnit(unit);

			if (unit.Components.OfType<Mobile>().SingleOrDefault() is Mobile mobile)
				Selection.Units.AddRange(mobile.Followers.Select(f => f.Self));

			OnSelectionRestored(EventArgs.Empty);
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (e.Button == MouseButtons.Left)
			{
				if (MouseOverUnit is not null && CanSelect(MouseOverUnit))
				{
					if (MouseOverUnit == Subject)
						CancelSelection();
					else if (SelectedUnits.Contains(MouseOverUnit))
					{
						_selectionState = SelectionState.Unselecting;

						RemoveSelectedUnit(MouseOverUnit);
					}
					else
					{
						_selectionState = SelectionState.Selecting;

						if (SelectedUnits.Any())
							AddSelectedUnit(MouseOverUnit);
						else
						{
							if (MouseOverUnit?.GetComponent<Airplane>() is not Airplane airplane || !airplane.IsInHangar)
								MouseFocusUnit = MouseOverUnit;

							RestoreSelection(MouseOverUnit);
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
