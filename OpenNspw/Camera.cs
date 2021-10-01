using Microsoft.Xna.Framework;
using MonoGame.Extended;

namespace OpenNspw;

internal sealed class Camera
{
	public WRect? MapBounds { get; }
	public bool FlipY { get; }

	public WRect Viewport { get; set; }

	public Camera(WRect? mapBounds, bool flipY = true)
	{
		MapBounds = mapBounds;
		FlipY = flipY;
	}

	public WPos Center
	{
		get => Viewport.Center;
		set => Viewport = WRect.FromCenter(MapBounds.HasValue ? value.Clamp(MapBounds.Value.Inflate(-Viewport.Size / 2)) : value, Viewport.Size);
	}

	public WPos Position
	{
		get => Center - (Viewport.Size / 2).FlipY(FlipY);
		set => Center = value + (Viewport.Size / 2).FlipY(FlipY);
	}

	public WPos ScreenToWorld(Vector2 value) => Position + new WVec(value).FlipY(FlipY);

	public Vector2 WorldToScreen(WPos value) => (value - Position).FlipY(FlipY).ToVector2();
	public RectangleF WorldToScreen(WRect value) => new(WorldToScreen(FlipY ? value.TopLeft : value.BottomLeft), value.Size.ToVector2());
}
