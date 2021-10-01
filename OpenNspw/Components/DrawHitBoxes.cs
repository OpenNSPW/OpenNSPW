using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using MonoGame.Extended;
using DColor = System.Drawing.Color;
using DPen = System.Drawing.Pen;

namespace OpenNspw.Components;

internal sealed record DrawHitBoxesOptions : IComponentOptions<DrawHitBoxes>
{
	public DrawHitBoxes CreateComponent(Unit self) => new(self, this);
}

internal sealed class DrawHitBoxes : IComponent<DrawHitBoxesOptions>, IDrawable
{
	public Unit Self { get; }
	public DrawHitBoxesOptions Options { get; }

	public DrawHitBoxes(Unit self, DrawHitBoxesOptions options)
	{
		Self = self;
		Options = options;
	}

	void IDrawable.Draw(Unit self, Graphics graphics, Camera camera)
	{
		foreach (var hitBox in self.HitBoxes)
			graphics.DrawRectangle(new DPen(DColor.Yellow), camera.WorldToScreen(hitBox).ToRectangle().ToDrawingRectangle());
	}
}
