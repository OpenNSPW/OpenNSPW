namespace OpenNspw.Scenarios.Multiplayer;

internal sealed class Scenario7 : MultiplayerScenario
{
	public Scenario7()
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
				.AddUnit("ap_jpn", new WPos(-7680, -4720), CardinalDirection.Northeast, unit =>
				{
					for (var i = 0; i < 5; i++)
						unit.AddAirplane("at_jpn");
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("ft_jpn");
					for (var i = 0; i < 1; i++)
						unit.AddAirplane("at_jpn");
				})

				.AddUnit("bb_jpn", new WPos(-7500, -4550), CardinalDirection.Northwest)
				.AddUnit("ca_jpn", new WPos(-7450, -4700), CardinalDirection.Northwest)
				.AddUnit("ca_jpn", new WPos(-7450, -4850), CardinalDirection.Northwest)
				.AddUnit("dd_jpn", new WPos(-7530, -5000), CardinalDirection.Northwest)
				.AddUnit("tr_jpn", new WPos(-7340, -4690), CardinalDirection.South)
				.AddUnit("tr_jpn", new WPos(-7360, -4840), CardinalDirection.Northwest)
				.AddUnit("tr_jpn", new WPos(-7340, -4990), CardinalDirection.North)
				.AddUnit("ca_jpn", new WPos(-7250, -5180), CardinalDirection.North)
				.AddUnit("ss_jpn", new WPos(-7800, -2000), CardinalDirection.East);
		});

		world.AddUnits(world.Players[1], world =>
		{
			world
				// Hawaii
				.AddUnit("sp_usa", new WPos(7200, -640), CardinalDirection.East)
				.AddUnit("gf3_usa", new WPos(7120, -480), CardinalDirection.East)
				.AddUnit("ap_usa", new WPos(7200, -560), CardinalDirection.Northeast, unit =>
				{
					for (var i = 0; i < 3; i++)
						unit.AddAirplane("g_ft_usa");
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("bm_usa");
					for (var i = 0; i < 4; i++)
						unit.AddAirplane("at_usa");
				})

				// Midway Atoll
				.AddUnit("gf2_usa", new WPos(240, 3360), CardinalDirection.East)
				.AddUnit("ap_usa", new WPos(80, 3440), CardinalDirection.Northeast, unit =>
				{
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_usa");
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("at_usa");
				})

				.AddUnit("cv_usa", new WPos(-3500, -3000), CardinalDirection.West, unit =>
				{
					for (var i = 0; i < 10; i++)
						unit.AddAirplane("at_usa");
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_usa");
				})
				.AddUnit("cvl_usa", new WPos(-3350, -3000), CardinalDirection.West, unit =>
				{
					for (var i = 0; i < 6; i++)
						unit.AddAirplane("at_usa");
					for (var i = 0; i < 2; i++)
						unit.AddAirplane("ft_usa");
				})
				.AddUnit("ca_usa", new WPos(-3200, -3000), CardinalDirection.West)
				.AddUnit("dd_usa", new WPos(-3050, -3000), CardinalDirection.West)
				.AddUnit("ca_usa", new WPos(-2900, -3000), CardinalDirection.West);
		});
	}
}
