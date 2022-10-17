namespace OpenNspw.Orders;

internal readonly record struct ClientId(int Value) : IFormattable
{
	public static readonly ClientId Zero = new();

	public override string ToString() => Value.ToString();
	public string ToString(string? format, IFormatProvider? provider) => Value.ToString(format, provider);
}
