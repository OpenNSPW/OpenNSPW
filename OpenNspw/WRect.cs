namespace OpenNspw;

internal readonly record struct WRect(WPos Center, WVec Size)
{
	public float Left => Center.X - Size.X / 2;
	public float Bottom => Center.Y - Size.Y / 2;
	public float Right => Center.X + Size.X / 2;
	public float Top => Center.Y + Size.Y / 2;

	public WPos BottomLeft => new(Left, Bottom);
	public WPos BottomRight => new(Right, Bottom);
	public WPos TopRight => new(Right, Top);
	public WPos TopLeft => new(Left, Top);

	public static WRect FromCenter(WPos center, WVec size) => new(center, size);

	public override string ToString() => $"(X: {Left}, Y: {Bottom}, Width: {Size.X}, Height: {Size.Y})";

	public bool Contains(WPos value) => value.X >= Left && value.X <= Right && value.Y >= Bottom && value.Y <= Top;

	public WRect Inflate(WVec size) => new(Center, Size + size * 2);

	public bool Intersects(WRect value) => value.Left < Right && Left < value.Right && value.Bottom < Top && Bottom < value.Top;
}
