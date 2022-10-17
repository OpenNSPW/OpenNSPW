namespace OpenNspw;

internal readonly record struct CVec(int X, int Y)
{
	public static readonly CVec Zero = new();

	public override string ToString() => (X, Y).ToString();
}
