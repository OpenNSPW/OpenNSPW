using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using Microsoft.Xna.Framework;
using DPen = System.Drawing.Pen;

namespace OpenNspw.Effects;

internal sealed class LineEffect : IEffect
{
	public EffectLayer Layer { get; }
	public int RemainingTicks { get; private set; }
	public WPos Point1 { get; }
	public WPos Point2 { get; }
	public Color Color { get; }
	public float Width { get; }

	public LineEffect(EffectLayer layer, int duration, WPos point1, WPos point2, Color color, float width = 1)
	{
		Layer = layer;
		RemainingTicks = duration;
		Point1 = point1;
		Point2 = point2;
		Color = color;
		Width = width;
	}

	public void Update(World world)
	{
		RemainingTicks--;

		if (RemainingTicks == 0)
			world.AddFrameEndAction(w => w.Remove(this));
	}

	public void Draw(World world, Graphics graphics, Camera camera)
	{
		// TODO: check visibility

		graphics.DrawLine(new DPen(Color.ToDrawingColor(), Width), camera.WorldToScreen(Point1).ToPoint().ToDrawingPoint(), camera.WorldToScreen(Point2).ToPoint().ToDrawingPoint());
	}
}
