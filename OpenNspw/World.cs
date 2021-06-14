using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using OpenNspw.Scenarios;

namespace OpenNspw
{
	internal sealed class World
	{
		public int FrameCount { get; set; }


		private readonly SortedDictionary<int, Unit> _units = new();

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

		public IEnumerable<Unit> Units => _units.Values;

		private int _nextUnitId = 1;

		public Unit CreateUnit(string name, Player owner, WPos center, WAngle angle)
		{
			var unit = new Unit(_nextUnitId++, this, name, owner, center, angle);
			return unit;
		}

		public void Add(Unit unit) => _units.Add(unit.Id, unit);

		public void Update()
		{
		}

		public void Draw(Graphics graphics, Camera camera)
		{
			Map.Draw(this, graphics, camera);

			foreach (var unit in Units.Where(u => camera.Viewport.Intersects(WRect.FromCenter(u.Center, new WVec(80, 80)))))
				unit.Draw(graphics, camera);
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
				// TODO: implement
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
