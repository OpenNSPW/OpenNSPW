using System;

namespace OpenNspw
{
	internal readonly struct WAngle : IEquatable<WAngle>
	{
		public static readonly WAngle Zero = new(0);

		private const float _degreeRadian = (float)(Math.PI / 180.0);
		private const float _radianDegree = (float)(180.0 / Math.PI);

		public float Degrees { get; }

		public WAngle(float degrees)
		{
			Degrees = degrees % 360;

			if (Degrees < 0)
				Degrees += 360;
		}

		public static WAngle FromRadians(float radians) => new(radians * _radianDegree);
		public static WAngle FromVector(WVec value) => FromRadians((float)Math.Atan2(value.Y, value.X));
		public static WAngle FromFacing(int facing) => new((facing + 1) % 16 / 2 * 45.0f);

		public float Radians => Degrees * _degreeRadian;

		public float Cos => (float)Math.Cos(Radians);
		public float Sin => (float)Math.Sin(Radians);

		public int Facing => (int)(Degrees / 22.5f);

		public static bool operator ==(WAngle left, WAngle right) => left.Equals(right);
		public static bool operator !=(WAngle left, WAngle right) => !left.Equals(right);

		public static WAngle operator -(WAngle value) => new(-value.Degrees);

		public static WAngle operator +(WAngle left, WAngle right) => new(left.Degrees + right.Degrees);
		public static WAngle operator -(WAngle left, WAngle right) => new(left.Degrees - right.Degrees);

		public bool Equals(WAngle other) => Degrees == other.Degrees;
		public override bool Equals(object? obj) => obj is WAngle other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(Degrees);

		public override string ToString() => Degrees.ToString();

		public WVec ToUnitVector() => new(Cos, Sin);
		public WVec ToVector(float length) => ToUnitVector() * length;
	}
}
