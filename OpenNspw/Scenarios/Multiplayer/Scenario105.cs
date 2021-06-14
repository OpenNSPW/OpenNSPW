namespace OpenNspw.Scenarios.Multiplayer
{
	internal sealed class Scenario105 : MultiplayerScenario
	{
		public Scenario105()
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
							unit.AddAirplane("g_ft_jpn");
						for (var i = 0; i < 5; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("bm_jpn");
					})

					// Bougainville Island
					.AddUnit("gf1_jpn", new WPos(-4480, 1200), CardinalDirection.East)
					.AddUnit("gf1_jpn", new WPos(-4320, 1040), CardinalDirection.East)
					.AddUnit("gf1_jpn", new WPos(-4080, 960), CardinalDirection.East)

					// Rabaul
					.AddUnit("ap_jpn", new WPos(-7520, 1840), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 1; i++)
							unit.AddAirplane("bm_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("g_ft_jpn");
					})

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
					// Nouméa
					.AddUnit("sp_usa", new WPos(5440, -5760), CardinalDirection.East)
					.AddUnit("ap_usa", new WPos(5280, -5760), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 5; i++)
							unit.AddAirplane("ft_usa");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("g_ft_usa");
						for (var i = 0; i < 5; i++)
							unit.AddAirplane("at_usa");
					})
					.AddUnit("gf1_usa", new WPos(5360, -5760), CardinalDirection.East)

					// Guadalcanal
					.AddUnit("gf1_usa", new WPos(-880, -240), CardinalDirection.East)
					.AddUnit("ap_usa", new WPos(-800, -240), CardinalDirection.Northeast)

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
					.AddUnit("bb_usa", new WPos(7100, -5000), CardinalDirection.West);
			});
		}
	}
}
