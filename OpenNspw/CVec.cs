namespace OpenNspw;

internal readonly struct CVec : IEquatable<CVec>
{
	public static readonly CVec Zero = new();

	public int X { get; }
	public int Y { get; }

	public CVec(int x, int y) => (X, Y) = (x, y);

	public static bool operator ==(CVec left, CVec right) => left.Equals(right);
	public static bool operator !=(CVec left, CVec right) => !left.Equals(right);

	public bool Equals(CVec other) => X == other.X && Y == other.Y;
	public override bool Equals(object? obj) => obj is CVec other && Equals(other);

	public override int GetHashCode() => (X, Y).GetHashCode();

	public override string ToString() => (X, Y).ToString();
}
