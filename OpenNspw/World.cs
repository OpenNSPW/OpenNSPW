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

		public int WorldTick { get; private set; }

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

		public void Add(Unit unit, bool toAll)
		{
			unit.IsInWorld = true;

			if (toAll)
				AllUnits.Add(unit);

			Units.Add(unit);

			foreach (var listener in unit.Components.OfType<IAddedToWorldEventListener>())
				listener.OnAddedToWorld(unit);
		}

		public void Remove(Unit unit, bool fromAll)
		{
			unit.IsInWorld = false;

			if (fromAll)
				AllUnits.Remove(unit);

			Units.Remove(unit);

			foreach (var listener in unit.Components.OfType<IRemovedFromWorldEventListener>())
				listener.OnRemovedFromWorld(unit);
		}

		public void DispatchOrder(IOrder order) => OrderManager.DispatchOrder(order);

		internal void HandleOrder(IOrder order)
		{
			switch (order)
			{
				case ISelectionOrder selectionOrder:
					foreach (var unit in selectionOrder.Selection)
						unit.HandleOrder(selectionOrder);
					break;

				case IUnitOrder unitOrder:
					unitOrder.Subject.HandleOrder(unitOrder);
					break;
			}
		}

		public void Update()
		{
			if (!OrderManager.IsReadyForNextFrame)
				return;

			foreach (var order in OrderManager.FrameData.OrdersForFrame(OrderManager.FrameId))
				HandleOrder(order);

			WorldTick++;

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

		public void PlaySoundForUnitOrder(IUnitOrder unitOrder)
		{
			switch (unitOrder)
			{
				case LandingCellOrder landingCellOrder:
					if (landingCellOrder.LandingCell is null)
						Sound.Play("SoundEffects/btn_6");
					else
						Sound.Play("SoundEffects/btn_3");
					break;

				case WaypointOrder:
					Sound.Play("SoundEffects/btn_4");
					break;

				case TargetOrder targetOrder:
					if (targetOrder.Target is null)
						Sound.Play("SoundEffects/btn_6");
					else
						Sound.Play("SoundEffects/btn_3");
					break;
			}
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
				unit.World.Add(unit, toAll: true);

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
				World.Add(unit, toAll: true);
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
