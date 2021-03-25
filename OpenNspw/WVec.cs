using System;
using Microsoft.Xna.Framework;

namespace OpenNspw
{
	internal readonly struct WVec : IEquatable<WVec>
	{
		public static readonly WVec Zero = new();

		public float X { get; }
		public float Y { get; }

		public WVec(float x, float y) => (X, Y) = (x, y);
		public WVec(Vector2 value) => (X, Y) = (value.X, value.Y);

		public float LengthSquared => X * X + Y * Y;
		public float Length => (float)Math.Sqrt(LengthSquared);

		public static bool operator ==(WVec left, WVec right) => left.Equals(right);
		public static bool operator !=(WVec left, WVec right) => !left.Equals(right);

		public static WVec operator -(WVec value) => new(-value.X, -value.Y);
		public static WVec operator +(WVec left, WVec right) => new(left.X + right.X, left.Y + right.Y);
		public static WVec operator *(WVec left, float right) => new(left.X * right, left.Y * right);
		public static WVec operator /(WVec dividend, float divisor) => new(dividend.X / divisor, dividend.Y / divisor);

		public bool Equals(WVec other) => X == other.X && Y == other.Y;
		public override bool Equals(object? obj) => obj is WVec other && Equals(other);

		public override int GetHashCode() => (X, Y).GetHashCode();

		public override string ToString() => (X, Y).ToString();

		public Vector2 ToVector2() => new(X, Y);
	}
}
