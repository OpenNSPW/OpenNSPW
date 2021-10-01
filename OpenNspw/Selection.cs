namespace OpenNspw;

internal sealed class Selection
{
	public List<Unit> Units { get; } = new();
	public Unit? MouseFocusUnit { get; set; }
	public bool IsQueued { get; set; }

	public void Clear()
	{
		Units.Clear();
		IsQueued = false;
	}
}
