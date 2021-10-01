using System.Collections;

namespace OpenNspw
{
	internal sealed class UnitCollection : IEnumerable<Unit>
	{
		private readonly SortedDictionary<int, Unit> _units = new();

		public Unit this[int id] => _units[id];

		public IEnumerator<Unit> GetEnumerator() => _units.Values.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Add(Unit unit) => _units.Add(unit.Id, unit);

		public void Remove(Unit unit) => _units.Remove(unit.Id);

		public bool Contains(Unit unit) => _units.ContainsValue(unit);
	}
}
