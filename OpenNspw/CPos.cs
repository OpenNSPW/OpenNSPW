using Microsoft.Xna.Framework;

namespace OpenNspw
{
	internal readonly struct CPos : IEquatable<CPos>
	{
		public static readonly CPos Zero = new();

		public int X { get; }
		public int Y { get; }

		public CPos(int x, int y) => (X, Y) = (x, y);
		public CPos(Point value) => (X, Y) = (value.X, value.Y);

		public static bool operator ==(CPos left, CPos right) => left.Equals(right);
		public static bool operator !=(CPos left, CPos right) => !left.Equals(right);

		public static CPos operator +(CPos left, CVec right) => new(left.X + right.X, left.Y + right.Y);

		public bool Equals(CPos other) => X == other.X && Y == other.Y;
		public override bool Equals(object? obj) => obj is CPos other && Equals(other);

		public override int GetHashCode() => (X, Y).GetHashCode();

		public override string ToString() => (X, Y).ToString();

		public Point ToPoint() => new(X, Y);
	}
}
