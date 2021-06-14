namespace OpenNspw.Scenarios.Multiplayer
{
	internal sealed class Scenario102 : MultiplayerScenario
	{
		public Scenario102()
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

					// Rabaul
					.AddUnit("ap_jpn", new WPos(-7520, 1840), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 5; i++)
							unit.AddAirplane("ft_jpn");
					})

					// Guadalcanal
					.AddUnit("gf1_jpn", new WPos(-880, -240), CardinalDirection.East)
					.AddUnit("ap_jpn", new WPos(-800, -240), CardinalDirection.Northeast)
					.AddUnit("gf2_jpn", new WPos(-960, -160), CardinalDirection.East)

					.AddUnit("cv_jpn", new WPos(-6500, 5000), CardinalDirection.East, unit =>
					{
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("ft_jpn");
					})
					.AddUnit("bb_jpn", new WPos(-6620, 5000), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-6740, 5000), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-6860, 5000), CardinalDirection.East)
					.AddUnit("dd_jpn", new WPos(-6980, 5000), CardinalDirection.East)
					.AddUnit("dd_jpn", new WPos(-7100, 5000), CardinalDirection.East)
					.AddUnit("ss_jpn", new WPos(-7220, 5000), CardinalDirection.East);
			});

			world.AddUnits(world.Players[1], world =>
			{
				world
					// Nouméa
					.AddUnit("sp_usa", new WPos(5440, -5760), CardinalDirection.East)
					.AddUnit("ap_usa", new WPos(5280, -5760), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 4; i++)
							unit.AddAirplane("ft_usa");
						for (var i = 0; i < 8; i++)
							unit.AddAirplane("at_usa");
					})
					.AddUnit("gf2_usa", new WPos(5360, -5760), CardinalDirection.East)

					.AddUnit("cv_usa", new WPos(6500, -5000), CardinalDirection.West, unit =>
					{
						for (var i = 0; i < 9; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("ft_usa");
					})
					.AddUnit("ca_usa", new WPos(6650, -5000), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(6800, -5000), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(6950, -5000), CardinalDirection.West)
					.AddUnit("bb_usa", new WPos(7100, -5000), CardinalDirection.West);
			});
		}
	}
}
