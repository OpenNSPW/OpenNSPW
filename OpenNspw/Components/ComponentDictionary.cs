// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/TraitDictionary.cs

namespace OpenNspw.Components;

internal sealed class ComponentDictionary
{
	private interface IComponentContainer
	{
		void Add(Unit unit, object component);
		void RemoveUnit(int id);
	}

	private sealed class ComponentContainer<T> : IComponentContainer
	{
		private readonly List<Unit> _units = new();
		private readonly List<T> _components = new();

		public void Add(Unit unit, object component)
		{
			var insertIndex = _units.BinarySearchMany(unit.Id + 1);
			_units.Insert(insertIndex, unit);
			_components.Insert(insertIndex, (T)component);
		}

		public T? GetValueOrDefault(Unit unit)
		{
			var index = _units.BinarySearchMany(unit.Id);
			if (index >= _units.Count || _units[index] != unit)
				return default;

			if (index + 1 < _units.Count && _units[index + 1] == unit)
				throw new InvalidOperationException($"Unit {unit.Name} has multiple components of type `{typeof(T)}`");

			return _components[index];
		}

		public T GetValue(Unit unit)
		{
			var result = GetValueOrDefault(unit);
			if (result is null)
				throw new InvalidOperationException($"Unit {unit.Name} does not have component of type `{typeof(T)}`");

			return result;
		}

		private struct MultipleEnumerator : IEnumerator<T>
		{
			private readonly List<Unit> _units;
			private readonly List<T> _components;
			private readonly int _id;
			private int _index;

			public MultipleEnumerator(ComponentContainer<T> container, int id) : this()
			{
				_units = container._units;
				_components = container._components;
				_id = id;
				Reset();
			}

			public void Reset()
			{
				_index = _units.BinarySearchMany(_id) - 1;
			}

			public bool MoveNext() => ++_index < _units.Count && _units[_index].Id == _id;

			public T Current => _components[_index];

			object System.Collections.IEnumerator.Current => Current;

			public void Dispose() { }
		}

		private sealed class MultipleEnumerable : IEnumerable<T>
		{
			private readonly ComponentContainer<T> _container;
			private readonly int _id;

			public MultipleEnumerable(ComponentContainer<T> container, int id)
			{
				_container = container;
				_id = id;
			}

			public IEnumerator<T> GetEnumerator() => new MultipleEnumerator(_container, _id);

			System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
		}

		public IEnumerable<T> GetMultiple(int id) => new MultipleEnumerable(this, id);

		public void RemoveUnit(int id)
		{
			var startIndex = _units.BinarySearchMany(id);
			if (startIndex >= _units.Count || _units[startIndex].Id != id)
				return;

			var endIndex = startIndex + 1;
			while (endIndex < _units.Count && _units[endIndex].Id == id)
				endIndex++;

			var count = endIndex - startIndex;
			_units.RemoveRange(startIndex, count);
			_components.RemoveRange(startIndex, count);
		}
	}

	private static readonly Func<Type, IComponentContainer> s_CreateComponentContainer = type => (IComponentContainer)typeof(ComponentContainer<>).MakeGenericType(type).GetConstructor(Type.EmptyTypes)!.Invoke(null);

	private readonly Dictionary<Type, IComponentContainer> _components = new();

	private IComponentContainer GetCore(Type type) => _components.GetOrAdd(type, s_CreateComponentContainer);

	private ComponentContainer<T> GetCore<T>() => (ComponentContainer<T>)GetCore(typeof(T));

	private void AddCore(Unit unit, Type type, object value) => GetCore(type).Add(unit, value);

	public void AddComponent(Unit unit, object value)
	{
		var type = value.GetType();

		foreach (var @interface in type.GetInterfaces())
			AddCore(unit, @interface, value);

		foreach (var baseType in type.GetBaseTypes())
			AddCore(unit, baseType, value);
	}

	public T GetValue<T>(Unit unit) => GetCore<T>().GetValue(unit);

	public T? GetValueOrDefault<T>(Unit unit) => GetCore<T>().GetValueOrDefault(unit);

	public IEnumerable<T> WithInterface<T>(Unit unit) => GetCore<T>().GetMultiple(unit.Id);
}
