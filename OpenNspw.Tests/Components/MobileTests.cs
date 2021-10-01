using FluentAssertions;
using OpenNspw.Components;
using OpenNspw.Orders;
using Xunit;

namespace OpenNspw.Tests.Components;

public class MobileTests
{
	private static World CreateWorld()
	{
		var assets = new FakeAssetManager();
		var scenario = new Scenarios.Singleplayer.Scenario1();
		var orderManager = new OrderManager(new EchoConnection());
		var map = new Map(scenario.MapName);
		var players = scenario.Players.Select(p => new Player(p.Faction, p.Color));
		var camera = new Camera(mapBounds: null);
		var world = World.Create(assets, sound: null!, scenario, orderManager, map, players, camera);
		return world;
	}

	[Fact]
	public void HandleOrderTest()
	{
		var world = CreateWorld();
		var (unit23, unit24, unit25, unit26, unit27) = (world.AllUnits[23], world.AllUnits[24], world.AllUnits[25], world.AllUnits[26], world.AllUnits[27]);

		world.Selection.Units.Clear();
		world.Selection.Units.Add(unit23);
		world.Selection.Units.Add(unit24);
		world.Selection.Units.Add(unit25);

		world.HandleOrder(new WaypointOrder(
			Subject: world.Selection.Units.First(),
			Selection: world.Selection.Units.ToArray(),
			Position: WPos.Zero,
			IsQueued: false
		));

		unit23.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit24, unit25 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit24.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit25.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit26.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit27.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());

		unit23.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit24.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit25.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		unit26.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		unit27.GetRequiredComponent<Ship>().Leader.Should().BeNull();

		world.Selection.Units.Clear();
		world.Selection.Units.Add(unit26);
		world.Selection.Units.Add(unit27);
		world.Selection.Units.Add(unit23);

		world.HandleOrder(new WaypointOrder(
			Subject: world.Selection.Units.First(),
			Selection: world.Selection.Units.ToArray(),
			Position: WPos.Zero,
			IsQueued: false
		));

		unit23.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit24.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit25.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit26.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit27, unit23 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit27.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());

		(unit23.GetRequiredComponent<Ship>().Leader == unit26.GetRequiredComponent<Ship>()).Should().BeTrue();
		unit24.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		unit25.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		unit26.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit27.GetRequiredComponent<Ship>().Leader == unit26.GetRequiredComponent<Ship>()).Should().BeTrue();
	}

	[Fact]
	public void HandleOrderTest2()
	{
		var world = CreateWorld();
		var (unit23, unit24, unit25, unit26, unit27) = (world.AllUnits[23], world.AllUnits[24], world.AllUnits[25], world.AllUnits[26], world.AllUnits[27]);

		world.Selection.Units.Clear();
		world.Selection.Units.Add(unit23);
		world.Selection.Units.Add(unit24);
		world.Selection.Units.Add(unit25);
		world.Selection.Units.Add(unit26);
		world.Selection.Units.Add(unit27);

		world.HandleOrder(new WaypointOrder(
			Subject: world.Selection.Units.First(),
			Selection: world.Selection.Units.ToArray(),
			Position: WPos.Zero,
			IsQueued: false
		));

		unit23.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit24, unit25, unit26, unit27 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit24.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit25.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit26.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit27.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());

		unit23.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit24.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit25.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit26.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit27.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();

		world.Selection.Units.Clear();
		world.Selection.Units.Add(unit23);
		world.Selection.Units.Add(unit24);
		world.Selection.Units.Add(unit26);
		world.Selection.Units.Add(unit27);

		world.HandleOrder(new WaypointOrder(
			Subject: world.Selection.Units.First(),
			Selection: world.Selection.Units.ToArray(),
			Position: WPos.Zero,
			IsQueued: false
		));

		unit23.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit24, unit26, unit27 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit24.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit25.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit26.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit27.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());

		unit23.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit24.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		unit25.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit26.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit27.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
	}

	[Fact]
	public void HandleOrderTest3()
	{
		var world = CreateWorld();
		var (unit23, unit24, unit25, unit26, unit27) = (world.AllUnits[23], world.AllUnits[24], world.AllUnits[25], world.AllUnits[26], world.AllUnits[27]);

		world.Selection.Units.Clear();
		world.Selection.Units.Add(unit23);
		world.Selection.Units.Add(unit24);
		world.Selection.Units.Add(unit25);
		world.Selection.Units.Add(unit26);
		world.Selection.Units.Add(unit27);

		world.HandleOrder(new WaypointOrder(
			Subject: world.Selection.Units.First(),
			Selection: world.Selection.Units.ToArray(),
			Position: WPos.Zero,
			IsQueued: false
		));

		unit23.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit24, unit25, unit26, unit27 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit24.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit25.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit26.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit27.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());

		unit23.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit24.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit25.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit26.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit27.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();

		world.Selection.Units.Clear();
		world.Selection.Units.Add(unit25);
		world.Selection.Units.Add(unit26);
		world.Selection.Units.Add(unit27);

		world.HandleOrder(new WaypointOrder(
			Subject: world.Selection.Units.First(),
			Selection: world.Selection.Units.ToArray(),
			Position: WPos.Zero,
			IsQueued: false
		));

		unit23.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit24 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit24.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit25.GetRequiredComponent<Ship>().Followers.Should().Equal(new[] { unit26, unit27 }.Select(u => u.GetRequiredComponent<Ship>()));
		unit26.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());
		unit27.GetRequiredComponent<Ship>().Followers.Should().Equal(Array.Empty<Ship>());

		unit23.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit24.GetRequiredComponent<Ship>().Leader == unit23.GetRequiredComponent<Ship>()).Should().BeTrue();
		unit25.GetRequiredComponent<Ship>().Leader.Should().BeNull();
		(unit26.GetRequiredComponent<Ship>().Leader == unit25.GetRequiredComponent<Ship>()).Should().BeTrue();
		(unit27.GetRequiredComponent<Ship>().Leader == unit25.GetRequiredComponent<Ship>()).Should().BeTrue();
	}
}
