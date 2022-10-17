using Microsoft.Xna.Framework;

namespace OpenNspw;

internal readonly record struct CPos(int X, int Y)
{
	public static readonly CPos Zero = new();

	public CPos(Point value) : this(value.X, value.Y) { }

	public static CPos operator +(CPos left, CVec right) => new(left.X + right.X, left.Y + right.Y);

	public override string ToString() => (X, Y).ToString();

	public Point ToPoint() => new(X, Y);
}
