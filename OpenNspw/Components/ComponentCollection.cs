namespace OpenNspw.Components;

internal sealed class ComponentCollection
{
	private readonly Unit _unit;

	public ComponentCollection(Unit unit)
	{
		_unit = unit;
	}

	public void Add(IComponent component) => _unit.World.Components.AddComponent(_unit, component);

	public T GetRequiredComponent<T>() where T : IComponent => _unit.World.Components.GetValue<T>(_unit);

	public T? GetComponent<T>() where T : IComponent => _unit.World.Components.GetValueOrDefault<T>(_unit);

	public IEnumerable<T> OfType<T>() => _unit.World.Components.WithInterface<T>(_unit);
}
