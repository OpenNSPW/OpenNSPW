using Microsoft.Xna.Framework;

namespace OpenNspw;

internal readonly record struct WVec(float X, float Y)
{
	public static readonly WVec Zero = new();

	public WVec(Vector2 value) : this(value.X, value.Y) { }

	public float LengthSquared => X * X + Y * Y;
	public float Length => (float)Math.Sqrt(LengthSquared);

	public static WVec operator -(WVec value) => new(-value.X, -value.Y);
	public static WVec operator +(WVec left, WVec right) => new(left.X + right.X, left.Y + right.Y);
	public static WVec operator *(WVec left, float right) => new(left.X * right, left.Y * right);
	public static WVec operator /(WVec dividend, float divisor) => new(dividend.X / divisor, dividend.Y / divisor);

	public override string ToString() => (X, Y).ToString();

	public Vector2 ToVector2() => new(X, Y);
}
