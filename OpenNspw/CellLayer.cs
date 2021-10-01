using MonoGame.Extended;

namespace OpenNspw;

internal sealed class CellLayer<T>
{
	public Size Size { get; }

	private readonly T[] _entries;

	public CellLayer()
	{
		Size = new Size(256, 256);
		_entries = new T[Size.Width * Size.Height];
	}

	private int IndexOf(CPos cell) => cell.Y * Size.Width + cell.X;

	public T this[CPos cell]
	{
		get => _entries[IndexOf(cell)];
		set => _entries[IndexOf(cell)] = value;
	}
}
