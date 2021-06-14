namespace OpenNspw.Scenarios.Multiplayer
{
	internal sealed class Scenario8 : MultiplayerScenario
	{
		public Scenario8()
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
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("ft_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("at_jpn");
					})

					// Wake Atoll
					.AddUnit("ap_jpn", new WPos(-4080, -720), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 6; i++)
							unit.AddAirplane("ft_jpn");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("at_jpn");
					})
					.AddUnit("gf1_jpn", new WPos(-4000, -880), CardinalDirection.East)

					.AddUnit("cv_jpn", new WPos(-7400, -4200), CardinalDirection.North, unit =>
					{
						for (var i = 0; i < 10; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_jpn");
					})
					.AddUnit("cvl_jpn", new WPos(-7400, -4290), CardinalDirection.North)
					.AddUnit("bb_jpn", new WPos(-7400, -4380), CardinalDirection.North)
					.AddUnit("ca_jpn", new WPos(-7400, -4470), CardinalDirection.North)
					.AddUnit("ca_jpn", new WPos(-7400, -4560), CardinalDirection.North)
					.AddUnit("dd_jpn", new WPos(-7400, -4650), CardinalDirection.North)
					.AddUnit("ca_jpn", new WPos(-7500, -4550), CardinalDirection.Northeast)
					.AddUnit("ca_jpn", new WPos(-7460, -4670), CardinalDirection.Northwest)
					.AddUnit("dd_jpn", new WPos(-7480, -4790), CardinalDirection.South)
					.AddUnit("ss_jpn", new WPos(-7800, -5000), CardinalDirection.Northeast);
			});

			world.AddUnits(world.Players[1], world =>
			{
				world
					// Hawaii
					.AddUnit("sp_usa", new WPos(7200, -640), CardinalDirection.East)
					.AddUnit("gf3_usa", new WPos(7200, -560), CardinalDirection.East)
					.AddUnit("ap_usa", new WPos(7280, -480), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 5; i++)
							unit.AddAirplane("ft_usa");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("bm_usa");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("g_ft_usa");
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

					.AddUnit("cv_usa", new WPos(3500, 3000), CardinalDirection.West, unit =>
					{
						for (var i = 0; i < 10; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_usa");
					})
					.AddUnit("cvl_usa", new WPos(3650, 3000), CardinalDirection.West, unit =>
					{
						for (var i = 0; i < 6; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_usa");
					})
					.AddUnit("ca_usa", new WPos(3800, 3000), CardinalDirection.West)
					.AddUnit("dd_usa", new WPos(3950, 3000), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(4100, 3000), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(7340, -560), CardinalDirection.Northeast)
					.AddUnit("bb_usa", new WPos(7460, -560), CardinalDirection.Northeast)
					.AddUnit("ss_usa", new WPos(7580, -560), CardinalDirection.Northeast);
			});
		}
	}
}
