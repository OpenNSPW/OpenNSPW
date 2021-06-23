using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using OpenNspw.Components;
using OpenNspw.Scenarios;

namespace OpenNspw
{
	internal sealed class World
	{
		public int FrameCount { get; set; }


		public UnitCollection AllUnits { get; } = new();
		public UnitCollection Units { get; } = new();

		public Selection Selection { get; } = new();

		public Map Map { get; }

		public IReadOnlyList<Player> Players { get; }

		public Scenario Scenario { get; }

		private World(Scenario scenario, Map map, IEnumerable<Player> players)
		{
			Scenario = scenario;
			Map = map;
			Players = players.ToArray();
		}

		public static World Create(Scenario scenario, Map map, IEnumerable<Player> players, Camera camera)
		{
			var world = new World(scenario, map, players);
			scenario.Initialize(world, camera);
			return world;
		}

		private int _nextUnitId = 1;

		public Unit CreateUnit(string name, Player owner, WPos center, WAngle angle)
		{
			var unit = new Unit(_nextUnitId++, this, name, owner)
			{
				Center = center,
				Angle = angle,
			};
			return unit;
		}

		public void Add(Unit unit)
		{
			AllUnits.Add(unit);
			Units.Add(unit);
		}

		public void Remove(Unit unit)
		{
			AllUnits.Remove(unit);
			Units.Remove(unit);
		}

		public void Update()
		{
		}

		public void Draw(Graphics graphics, Camera camera)
		{
			Map.Draw(this, graphics, camera);
		}
	}

	internal static class WorldExtensions
	{
		public sealed class UnitBuilder
		{
			public Unit Unit { get; }

			public UnitBuilder(Unit unit)
			{
				Unit = unit;
			}

			public UnitBuilder AddAirplane(string name)
			{
				var unit = Unit.World.CreateUnit(name, Unit.Owner, Unit.Center, Unit.Angle);
				unit.World.Add(unit);

				var airplane = unit.GetRequiredComponent<Airplane>();
				var hangar = Unit.GetRequiredComponent<Hangar>();
				hangar.Add(airplane);
				hangar.Park(airplane);
				return this;
			}
		}

		public sealed class WorldBuilder
		{
			public World World { get; }
			public Player Owner { get; }

			public WorldBuilder(World world, Player owner)
			{
				World = world;
				Owner = owner;
			}

			public WorldBuilder AddUnit(string name, WPos center, WAngle angle, Action<UnitBuilder>? callback = null)
			{
				var unit = World.CreateUnit(name, Owner, center, angle);
				World.Add(unit);
				callback?.Invoke(new UnitBuilder(unit));
				return this;
			}
		}

		public static void AddUnits(this World world, Player owner, Action<WorldBuilder> callback)
		{
			callback(new WorldBuilder(world, owner));
		}
	}
}
