namespace OpenNspw.Scenarios.Multiplayer;

internal sealed class Scenario4 : MultiplayerScenario
{
	public Scenario4()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		world.AddUnits(world.Players[0], world =>
		{
			world
				// Kwajalein Atoll
				.AddUnit("sp_jpn", new WPos(-7120, 6720), CardinalDirection.East)
				.AddUnit("gf1_jpn", new WPos(-7200, 6720), CardinalDirection.East)

				.AddUnit("bb_jpn", new WPos(-2500, 2500), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-2620, 2500), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-2740, 2500), CardinalDirection.East)
				.AddUnit("dd_jpn", new WPos(-2860, 2500), CardinalDirection.East)
				.AddUnit("dd_jpn", new WPos(-2980, 2500), CardinalDirection.East)
				.AddUnit("dd_jpn", new WPos(-3100, 2500), CardinalDirection.East);
		});

		world.AddUnits(world.Players[1], world =>
		{
			world
				// Nouméa
				.AddUnit("sp_usa", new WPos(5440, -5760), CardinalDirection.East)
				.AddUnit("gf1_usa", new WPos(5360, -5840), CardinalDirection.East)

				.AddUnit("bb_usa", new WPos(2500, -2500), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(2620, -2500), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(2740, -2500), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(2860, -2500), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(2980, -2500), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(3100, -2500), CardinalDirection.West);
		});
	}
}
