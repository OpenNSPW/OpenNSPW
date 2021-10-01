namespace OpenNspw.Components
{
	internal sealed class ComponentCollection
	{
		private readonly Dictionary<Type, IComponent> _components = new();

		public void Add(IComponent component) => _components.Add(component.GetType(), component);

		public T GetRequiredComponent<T>() where T : notnull => (T)_components[typeof(T)];

		public T? GetComponent<T>() => (T?)_components.GetValueOrDefault(typeof(T));

		public IEnumerable<T> OfType<T>() => _components.Values.OfType<T>();
	}
}
