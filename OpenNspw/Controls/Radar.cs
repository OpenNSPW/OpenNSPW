using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using DColor = System.Drawing.Color;
using DPen = System.Drawing.Pen;
using DPoint = System.Drawing.Point;
using DRect = System.Drawing.Rectangle;
using DSize = System.Drawing.Size;
using DSolidBrush = System.Drawing.SolidBrush;

namespace OpenNspw.Controls
{
	internal sealed class Radar : Control
	{
		private readonly World _world;
		private readonly Map _map;
		private readonly Camera _camera;

		private readonly Texture2D _texture;

		private Texture2D CreateRadarTexture(SpriteBatch spriteBatch)
		{
			var texture = new RenderTarget2D(spriteBatch.GraphicsDevice, Size.Width, Size.Height);
			spriteBatch.GraphicsDevice.SetRenderTarget(texture);

			spriteBatch.Begin();
			spriteBatch.GraphicsDevice.Clear(new Color(165, 206, 247));

			for (var y = 0; y < Size.Height / 20; y++)
			{
				for (var x = 0; x < Size.Width / 20; x++)
					spriteBatch.FillRectangle(new Rectangle(x * 20, y * 20, 20, 20), ((x + y) % 2 == 0) ? new Color(96, 80, 64) : new Color(101, 85, 69));
			}

			for (var y = 0; y < _map.Height; y++)
			{
				for (var x = 0; x < _map.Width; x++)
				{
					if (_map.Tiles[new CPos(x, y)] != 0)
						spriteBatch.DrawPoint(new Vector2(x, y), new Color(0, 175, 0));
				}
			}

			spriteBatch.End();

			spriteBatch.GraphicsDevice.SetRenderTarget(null);

			return texture;
		}

		public Radar(World world, Camera camera, GraphicsDevice graphicsDevice)
		{
			Size = new DSize(240, 180);
			BackColor = DColor.Transparent;

			_world = world;
			_map = world.Map;
			_camera = camera;

			using var spriteBatch = new SpriteBatch(graphicsDevice);
			_texture = CreateRadarTexture(spriteBatch);
		}

		private bool _isDisposed;

		protected override void Dispose(bool disposing)
		{
			if (_isDisposed)
				return;

			if (disposing)
				_texture.Dispose();

			_isDisposed = true;

			base.Dispose(disposing);
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);

			e.Graphics.DrawImage(MonoGameImage.Create(_texture, Color.White), DPoint.Empty);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			var location = _map.CellContaining(_camera.Position).ToPoint().ToDrawingPoint();
			var size = Vector2.Ceiling(_camera.Viewport.Size.ToVector2() / new Vector2(80, 80)).ToPoint().ToDrawingPoint();
			e.Graphics.DrawRectangle(new DPen(DColor.White), new DRect(location, (DSize)size));

			foreach (var unit in _world.Units)
			{
				var cell = _map.CellContaining(unit.Center);
				e.Graphics.FillRectangle(new DSolidBrush(unit.Owner.Color.ToDrawingColor()), new DRect(cell.X - 1, cell.Y - 1, 3, 3));
			}
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (e.Button == MouseButtons.Left)
				_camera.Center = _map.CenterOfCell(new CPos(e.Location.ToXnaPoint()));
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (e.Button == MouseButtons.Left)
				_camera.Center = _map.CenterOfCell(new CPos(e.Location.ToXnaPoint()));
		}
	}
}
