using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.TextureAtlases;

namespace OpenNspw
{
	internal sealed class Unit
	{
		public int Id { get; }
		public World World { get; }
		public Player Owner { get; }
		public WPos Center { get; }
		public string Name { get; }
		public Texture2D Texture { get; }
		public WAngle Angle { get; }

		public Unit(int id, World world, string name, Player owner, WPos center, WAngle angle)
		{
			Id = id;
			World = world;
			Name = name;
			Owner = owner;
			Center = center;
			Angle = angle;

			Texture = Assets.Textures[$"Textures/Units/{name}"];
		}

		public void Draw(Graphics graphics, Camera camera)
		{
			var sprite = new Sprite(new TextureRegion2D(Texture, new Rectangle(80 * (Angle.Quantize() % (Texture.Width / 80)), 0, 80, 80)));
			graphics.DrawImage(MonoGameImage.Create(sprite), camera.WorldToScreen(Center).ToPoint().ToDrawingPoint());
		}
	}
}
