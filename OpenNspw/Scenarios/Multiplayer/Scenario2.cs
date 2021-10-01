namespace OpenNspw.Scenarios.Multiplayer;

internal sealed class Scenario2 : MultiplayerScenario
{
	public Scenario2()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		world.AddUnits(world.Players[0], world =>
		{
			world
				// Truk Atoll
				.AddUnit("sp_jpn", new WPos(-7600, -4720), CardinalDirection.East)
				.AddUnit("gf1_jpn", new WPos(-7680, -4720), CardinalDirection.East)

				.AddUnit("cv_jpn", new WPos(-5000, -2500), CardinalDirection.East, unit =>
				{
					for (var i = 0; i < 9; i++)
						unit.AddAirplane("at_jpn");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_jpn");
				})
				.AddUnit("cvl_jpn", new WPos(-5120, -2500), CardinalDirection.East, unit =>
				{
					for (var i = 0; i < 6; i++)
						unit.AddAirplane("at_jpn");
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_jpn");
				})
				.AddUnit("dd_jpn", new WPos(-5240, -2500), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-5360, -2500), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-5480, -2500), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-5600, -2500), CardinalDirection.East)
				.AddUnit("dd_jpn", new WPos(-5720, -2500), CardinalDirection.East);
		});

		world.AddUnits(world.Players[1], world =>
		{
			world
				// Hawaii
				.AddUnit("sp_usa", new WPos(7200, -720), CardinalDirection.East)
				.AddUnit("gf1_usa", new WPos(7120, -640), CardinalDirection.East)

				.AddUnit("cv_usa", new WPos(5000, 2500), CardinalDirection.West, unit =>
				{
					for (var i = 0; i < 9; i++)
						unit.AddAirplane("at_usa");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_usa");
				})
				.AddUnit("cvl_usa", new WPos(5150, 2500), CardinalDirection.West, unit =>
				{
					for (var i = 0; i < 6; i++)
						unit.AddAirplane("at_usa");
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_usa");
				})
				.AddUnit("dd_usa", new WPos(5300, 2500), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(5450, 2500), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(5600, 2500), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(5750, 2500), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(5900, 2500), CardinalDirection.West);
		});
	}
}
