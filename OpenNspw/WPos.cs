namespace OpenNspw;

internal readonly struct WPos : IEquatable<WPos>
{
	public static readonly WPos Zero = new();

	public float X { get; }
	public float Y { get; }

	public WPos(float x, float y) => (X, Y) = (x, y);

	public static bool operator ==(WPos left, WPos right) => left.Equals(right);
	public static bool operator !=(WPos left, WPos right) => !left.Equals(right);

	public static WPos operator +(WPos left, WVec right) => new(left.X + right.X, left.Y + right.Y);
	public static WVec operator -(WPos left, WPos right) => new(left.X - right.X, left.Y - right.Y);
	public static WPos operator -(WPos left, WVec right) => new(left.X - right.X, left.Y - right.Y);

	public bool Equals(WPos other) => X == other.X && Y == other.Y;
	public override bool Equals(object? obj) => obj is WPos other && Equals(other);

	public override int GetHashCode() => (X, Y).GetHashCode();

	public override string ToString() => (X, Y).ToString();

	public WPos Clamp(WRect rectangle) => new(Math.Clamp(X, rectangle.Left, rectangle.Right), Math.Clamp(Y, rectangle.Bottom, rectangle.Top));
}
