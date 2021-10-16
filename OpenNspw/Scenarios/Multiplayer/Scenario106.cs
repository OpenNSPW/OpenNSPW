namespace OpenNspw.Scenarios.Multiplayer;

internal sealed class Scenario106 : MultiplayerScenario
{
	public Scenario106()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		world.AddUnits(world.Players[0], world =>
		{
			world
				// Kwajalein Atoll
				.AddUnit("sp_jpn", new WPos(-7120, 6640), CardinalDirection.East)
				.AddUnit("ap_jpn", new WPos(-7200, 6720), CardinalDirection.Northeast, unit =>
				{
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_jpn");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("at_jpn");
				})

				.AddUnit("cvl_jpn", new WPos(-7000, 5000), CardinalDirection.East, unit =>
				{
					for (var i = 0; i < 4; i++)
						unit.AddAirplane("at_jpn");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_jpn");
				})
				.AddUnit("dd_jpn", new WPos(-7120, 5000), CardinalDirection.East)
				.AddUnit("ca_jpn", new WPos(-7240, 5000), CardinalDirection.East)
				.AddUnit("dd_jpn", new WPos(-7360, 5000), CardinalDirection.East)
				.AddUnit("tr_gf1_jpn", new WPos(-7480, 5000), CardinalDirection.East)

				// Guadalcanal
				.AddUnit("gf1_jpn", new WPos(-1040, -160), CardinalDirection.East)
				.AddUnit("gf1_jpn", new WPos(-960, -160), CardinalDirection.East)
				.AddUnit("gf1_jpn", new WPos(-960, -240), CardinalDirection.East);
		});

		world.AddUnits(world.Players[1], world =>
		{
			world
				// Nouméa
				.AddUnit("sp_usa", new WPos(5440, -5760), CardinalDirection.East)
				.AddUnit("ap_usa", new WPos(5280, -5760), CardinalDirection.Northeast, unit =>
				{
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_usa");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("at_usa");
				})

				.AddUnit("cvl_usa", new WPos(6500, -5000), CardinalDirection.West, unit =>
				{
					for (var i = 0; i < 4; i++)
						unit.AddAirplane("at_usa");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_usa");
				})
				.AddUnit("dd_usa", new WPos(6650, -5000), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(6800, -5000), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(6950, -5000), CardinalDirection.West)
				.AddUnit("tr_gf1_usa", new WPos(7100, -5000), CardinalDirection.West)

				// Guadalcanal
				.AddUnit("gf1_usa", new WPos(-880, -240), CardinalDirection.East)
				.AddUnit("ap_usa", new WPos(-800, -240), CardinalDirection.Northeast)
				.AddUnit("gf1_usa", new WPos(-800, -160), CardinalDirection.East)
				.AddUnit("gf1_usa", new WPos(-880, -160), CardinalDirection.East);
		});
	}
}
