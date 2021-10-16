using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.TextureAtlases;

namespace OpenNspw.Components;

internal sealed record DrawUnitOptions : ConditionalComponentOptions<DrawUnit>
{
	public string? Texture { get; init; }

	public override DrawUnit CreateComponent(Unit self) => new(self, this);
}

internal sealed class DrawUnit : ConditionalComponent<DrawUnitOptions>, IDrawable
{
	public Texture2D Texture { get; set; }

	public DrawUnit(Unit self, DrawUnitOptions options) : base(self, options)
	{
		Texture = self.World.Assets.Textures[$"Textures/Units/{Options.Texture ?? self.Name}"];
	}

	void IDrawable.Draw(Unit self, Graphics graphics, Camera camera)
	{
		var sprite = new Sprite(new TextureRegion2D(Texture, new Rectangle(80 * (self.Angle.Quantize() % (Texture.Width / 80)), 0, 80, 80)));
		graphics.DrawImage(MonoGameImage.Create(sprite), camera.WorldToScreen(self.Center).ToPoint().ToDrawingPoint());
	}
}
