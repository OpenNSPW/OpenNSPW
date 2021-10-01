using OpenNspw.Activities;

namespace OpenNspw.Components;

internal sealed record HangarOptions : IComponentOptions<Hangar>
{
	public int Capacity { get; init; }
	public int Offset { get; init; }
	public HashSet<string> Types { get; init; } = new();

	public Hangar CreateComponent(Unit self) => new(self, this);
}

internal sealed class Hangar : IComponent<HangarOptions>, IUpdatable
{
	public Unit Self { get; }
	public HangarOptions Options { get; }
	public int TakeOffCount { get; set; }

	private readonly Dictionary<Airplane, int> _indices = new();

	private readonly List<Airplane> _airplanes = new();
	public IEnumerable<Airplane> Airplanes => _airplanes;

	public Hangar(Unit self, HangarOptions options)
	{
		Self = self;
		Options = options;
	}

	private bool HasSpace => Airplanes.Count() < Options.Capacity;

	public bool AllowTakeoff
	{
		get
		{
			if (Self.DamageState >= DamageState.Critical)
				return false;

			if (Airplanes.Any(a => a.Self.CurrentActivity is TakeOff or Land))
				return false;

			return true;
		}
	}

	public bool AllowLanding
	{
		get
		{
			if (Self.DamageState >= DamageState.Critical)
				return false;

			if (!HasSpace)
				return false;

			if (Airplanes.Any(a => a.Self.CurrentActivity is TakeOff))
				return false;

			if (Airplanes.Any(a => (a.Self.CurrentActivity as Land)?.LandState == LandState.Approach))
				return false;

			return true;
		}
	}

	void IUpdatable.Update(Unit self)
	{
		foreach (var airplane in Airplanes.Where(a => !(a.Self.CurrentActivity is TakeOff or Land)))
			airplane.Waypoints[0] = self.Center;
	}

	public void Add(Airplane airplane)
	{
		int ChooseFreeAirplaneIndex()
		{
			for (var i = 0; true; i++)
			{
				if (!_indices.ContainsValue(i))
					return i;
			}
		}

		_indices.Add(airplane, ChooseFreeAirplaneIndex());
		_airplanes.Add(airplane);

		airplane.Hangar = this;

		Self.World.Remove(airplane.Self, fromAll: false);
	}

	public void Park(Airplane airplane)
	{
		var index = _indices[airplane];
		switch (index % 2)
		{
			case 0:
				airplane.Angle = CardinalDirection.Southwest;
				airplane.Center = new WPos(117/* TODO: const */ / 2 + Options.Offset, 436/* TODO: const */ - index / 2 * 40 - 100);
				break;

			case 1:
				airplane.Angle = CardinalDirection.Southeast;
				airplane.Center = new WPos(117/* TODO: const */ / 2 - Options.Offset, 436/* TODO: const */ - index / 2 * 40 - 100 - 20);
				break;
		}

		airplane.Fold();
	}

	public void Remove(Airplane airplane)
	{
		_indices.Remove(airplane);
		_airplanes.Remove(airplane);

		Self.World.Add(airplane.Self, toAll: false);
	}
}
