using System.Collections.Generic;

namespace OpenNspw.Components
{
	internal sealed record HangarOptions : IComponentOptions<Hangar>
	{
		public int Capacity { get; init; }
		public int Offset { get; init; }

		public Hangar CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Hangar : IComponent<HangarOptions>
	{
		public Unit Self { get; }
		public HangarOptions Options { get; }

		private readonly Dictionary<Airplane, int> _indices = new();

		private readonly List<Airplane> _airplanes = new();
		public IEnumerable<Airplane> Airplanes => _airplanes;

		public Hangar(Unit self, HangarOptions options)
		{
			Self = self;
			Options = options;
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

			Self.World.Units.Remove(airplane.Self);

			_indices.Add(airplane, ChooseFreeAirplaneIndex());
			_airplanes.Add(airplane);

			airplane.Hangar = this;
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
		}
	}
}
