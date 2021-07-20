using System;
using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using OpenNspw.Components;
using OpenNspw.Orders;
using OpenNspw.Scenarios;

namespace OpenNspw
{
	internal sealed class World
	{
		public IAssetManager Assets { get; }
		public Sound Sound { get; }

		public int FrameCount { get; set; }

		public Camera Camera { get; }

		public UnitCollection AllUnits { get; } = new();
		public UnitCollection Units { get; } = new();

		public Selection Selection { get; } = new();

		public Map Map { get; }

		public OrderManager OrderManager { get; }

		public IReadOnlyList<Player> Players { get; }

		private int _localPlayerIndex;
		public Player LocalPlayer => Players[_localPlayerIndex];

		public void SetLocalPlayerIndex(int value)
		{
			if (value == _localPlayerIndex)
				return;

			_localPlayerIndex = value;
		}

		public Scenario Scenario { get; }

		public Random Random { get; } = new();

		private World(
			IAssetManager assets,
			Sound sound,
			Scenario scenario,
			OrderManager orderManager,
			Map map,
			IEnumerable<Player> players,
			Camera camera
		)
		{
			Assets = assets;
			Sound = sound;
			Scenario = scenario;
			OrderManager = orderManager;
			Map = map;
			Players = players.ToArray();
			Camera = camera;
		}

		public static World Create(
			IAssetManager assets,
			Sound sound,
			Scenario scenario,
			OrderManager orderManager,
			Map map,
			IEnumerable<Player> players,
			Camera camera
		)
		{
			var world = new World(assets, sound, scenario, orderManager, map, players, camera);
			scenario.Initialize(world, camera);
			return world;
		}

		private int _nextUnitId = 1;

		public Unit CreateUnit(string name, Player owner, WPos center, WAngle angle) => Unit.Create(_nextUnitId++, this, name, owner, center, angle);

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

		public void DispatchOrder(IOrder order) => OrderManager.DispatchOrder(order);

		private void HandleOrder(IOrder order)
		{
			switch (order)
			{
				case IUnitOrder unitOrder:
					var subject = AllUnits[unitOrder.SubjectId];
					subject.HandleOrder(unitOrder);
					break;
			}
		}

		public void Update()
		{
			if (!OrderManager.IsReadyForNextFrame)
				return;

			foreach (var order in OrderManager.FrameData.OrdersForFrame(OrderManager.FrameId))
				HandleOrder(order);

			foreach (var unit in AllUnits)
				unit.Update();
		}

		public void Draw(Graphics graphics, Camera camera)
		{
			Map.Draw(this, graphics, camera);
		}

		public void PlaySound(string name, WPos position)
		{
			// TODO: check visibility

			if (!WRect.FromCenter(Camera.Center, new WVec(768, 768)).Inflate(new WVec(500, 500)).Contains(position))
				return;

			Sound.Play(name);
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
