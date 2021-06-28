using System;

namespace OpenNspw.Orders
{
	internal readonly struct FrameId : IEquatable<FrameId>, IComparable<FrameId>, IFormattable
	{
		public static readonly FrameId Zero = new();
		public static readonly FrameId MaxValue = new FrameId(int.MaxValue);

		public int Value { get; }

		public FrameId(int value) => Value = value;

		public static FrameId operator ++(FrameId value) => new FrameId(value.Value + 1);

		public static bool operator ==(FrameId left, FrameId right) => left.Equals(right);
		public static bool operator !=(FrameId left, FrameId right) => !left.Equals(right);

		public static bool operator <(FrameId left, FrameId right) => left.CompareTo(right) < 0;
		public static bool operator <=(FrameId left, FrameId right) => left.CompareTo(right) <= 0;
		public static bool operator >(FrameId left, FrameId right) => left.CompareTo(right) > 0;
		public static bool operator >=(FrameId left, FrameId right) => left.CompareTo(right) >= 0;

		public static FrameId operator +(FrameId left, int right) => new FrameId(left.Value + right);

		public bool Equals(FrameId other) => Value == other.Value;
		public override bool Equals(object? obj) => obj is FrameId other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(Value);

		public int CompareTo(FrameId other) => Value.CompareTo(other.Value);

		public override string ToString() => Value.ToString();
		public string ToString(string? format, IFormatProvider? provider) => Value.ToString(format, provider);
	}
}
