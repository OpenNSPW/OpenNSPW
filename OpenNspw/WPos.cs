namespace OpenNspw;

internal readonly record struct WPos(float X, float Y)
{
	public static readonly WPos Zero = new();

	public static WPos operator +(WPos left, WVec right) => new(left.X + right.X, left.Y + right.Y);
	public static WVec operator -(WPos left, WPos right) => new(left.X - right.X, left.Y - right.Y);
	public static WPos operator -(WPos left, WVec right) => new(left.X - right.X, left.Y - right.Y);

	public override string ToString() => (X, Y).ToString();

	public WPos Clamp(WRect rectangle) => new(Math.Clamp(X, rectangle.Left, rectangle.Right), Math.Clamp(Y, rectangle.Bottom, rectangle.Top));
}
