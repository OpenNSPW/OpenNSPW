using System.IO;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.TextureAtlases;

namespace OpenNspw
{
	internal sealed class Map
	{
		public Size MapSize { get; }

		public int Width => MapSize.Width;
		public int Height => MapSize.Height;

		public WRect Bounds { get; }

		public CellLayer<short> Tiles { get; } = new();

		public Map(string name)
		{
			MapSize = new Size(240, 180);
			Bounds = WRect.FromCenter(WPos.Zero, new WVec(Width * 80, Height * 80));

			using var stream = TitleContainer.OpenStream(name);
			using var reader = new BinaryReader(stream);
			for (var y = 0; y < Tiles.Size.Height; y++)
			{
				for (var x = 0; x < Tiles.Size.Width; x++)
					Tiles[new CPos(x, y)] = reader.ReadInt16();
			}
		}

		public CPos CellContaining(WPos value) => new(Vector2.Floor(((value - Bounds.TopLeft).FlipY().ToVector2() + new Vector2(40, 40)) / new Vector2(80, 80)).ToPoint());

		public WPos CenterOfCell(CPos value) => Bounds.TopLeft + new WVec(value.X * 80, value.Y * 80).FlipY();

		public bool Contains(WPos value) => Bounds.Contains(value);

		public void Draw(World world, Graphics graphics, Camera camera)
		{
			var viewport = camera.Viewport;
			var topLeft = CellContaining(viewport.TopLeft);
			var bottomRight = CellContaining(viewport.BottomRight);
			for (var y = topLeft.Y; y <= bottomRight.Y; y++)
			{
				for (var x = topLeft.X; x <= bottomRight.X; x++)
				{
					var cell = new CPos(x, y);
					if (new Rectangle(Point.Zero, MapSize).Contains(cell))
					{
						var texture = Assets.Textures["Textures/terrain"];
						var tile = Tiles[cell];
						var sprite = new Sprite(new TextureRegion2D(texture, tile switch
						{
							0 => new Rectangle(80 * (world.FrameCount / 30 % 2), 0, 80, 80),
							_ => new Rectangle(80 * ((5 + tile) % 6), 80 * ((5 + tile) / 6), 80, 80),
						}));
						graphics.DrawImage(MonoGameImage.Create(sprite), camera.WorldToScreen(CenterOfCell(cell)).ToPoint().ToDrawingPoint());
					}
				}
			}
		}
	}
}
