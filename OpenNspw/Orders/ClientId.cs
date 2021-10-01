namespace OpenNspw.Orders
{
	internal readonly struct ClientId : IEquatable<ClientId>, IFormattable
	{
		public static readonly ClientId Zero = new();

		public int Value { get; }

		public ClientId(int value) => Value = value;

		public static bool operator ==(ClientId left, ClientId right) => left.Equals(right);
		public static bool operator !=(ClientId left, ClientId right) => !left.Equals(right);

		public bool Equals(ClientId other) => Value == other.Value;
		public override bool Equals(object? obj) => obj is ClientId other && Equals(other);

		public override int GetHashCode() => HashCode.Combine(Value);

		public override string ToString() => Value.ToString();
		public string ToString(string? format, IFormatProvider? provider) => Value.ToString(format, provider);
	}
}
