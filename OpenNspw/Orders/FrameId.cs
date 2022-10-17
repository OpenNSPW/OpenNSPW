namespace OpenNspw.Orders;

internal readonly record struct FrameId(int Value) : IComparable<FrameId>, IFormattable
{
	public static readonly FrameId Zero = new();
	public static readonly FrameId MaxValue = new FrameId(int.MaxValue);

	public static FrameId operator ++(FrameId value) => new FrameId(value.Value + 1);

	public static bool operator <(FrameId left, FrameId right) => left.CompareTo(right) < 0;
	public static bool operator <=(FrameId left, FrameId right) => left.CompareTo(right) <= 0;
	public static bool operator >(FrameId left, FrameId right) => left.CompareTo(right) > 0;
	public static bool operator >=(FrameId left, FrameId right) => left.CompareTo(right) >= 0;

	public static FrameId operator +(FrameId left, int right) => new FrameId(left.Value + right);

	public int CompareTo(FrameId other) => Value.CompareTo(other.Value);

	public override string ToString() => Value.ToString();
	public string ToString(string? format, IFormatProvider? provider) => Value.ToString(format, provider);
}
