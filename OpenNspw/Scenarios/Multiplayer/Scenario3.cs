namespace OpenNspw.Scenarios.Multiplayer;

internal sealed class Scenario3 : MultiplayerScenario
{
	public Scenario3()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		world.AddUnits(world.Players[0], world =>
		{
			world
				// Yokosuka
				.AddUnit("sp_jpn", new WPos(-7440, 4880), CardinalDirection.East)
				.AddUnit("gf1_jpn", new WPos(-7520, 4960), CardinalDirection.East)

				.AddUnit("cv_jpn", new WPos(-6500, 5000), CardinalDirection.East, unit =>
				{
					for (var i = 0; i < 9; i++)
						unit.AddAirplane("at_jpn");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_jpn");
				})
				.AddUnit("dd_jpn", new WPos(-6620, 5000), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-6740, 5000), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-6860, 5000), CardinalDirection.East)
				.AddUnit("bb_jpn", new WPos(-6980, 5000), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-7100, 5000), CardinalDirection.East)
				.AddUnit("dd_jpn", new WPos(-7220, 5000), CardinalDirection.East);
		});

		world.AddUnits(world.Players[1], world =>
		{
			world
				// Palau
				.AddUnit("sp_usa", new WPos(6640, -3760), CardinalDirection.East)
				.AddUnit("gf1_usa", new WPos(6640, -3680), CardinalDirection.East)

				.AddUnit("cv_usa", new WPos(6500, -5000), CardinalDirection.West, unit =>
				{
					for (var i = 0; i < 9; i++)
						unit.AddAirplane("at_usa");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_usa");
				})
				.AddUnit("dd_usa", new WPos(6650, -5000), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(6800, -5000), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(6950, -5000), CardinalDirection.West)
				.AddUnit("bb_usa", new WPos(7100, -5000), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(7250, -5000), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(7400, -5000), CardinalDirection.West);
		});
	}
}
