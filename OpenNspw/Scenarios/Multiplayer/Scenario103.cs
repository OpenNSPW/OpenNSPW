namespace OpenNspw.Scenarios.Multiplayer
{
	internal sealed class Scenario103 : MultiplayerScenario
	{
		public Scenario103()
		{
			MapName = "Content/Maps/japan.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			world.AddUnits(world.Players[0], world =>
			{
				world
					// Tokyo
					.AddUnit("ap_jpn", new WPos(-7440, 5440), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("at_jpn");
					})
					.AddUnit("ct_jpn", new WPos(-7760, 5280), CardinalDirection.East)
					.AddUnit("ct_jpn", new WPos(-7600, 5040), CardinalDirection.East)
					.AddUnit("ct_jpn", new WPos(-7680, 5360), CardinalDirection.East)
					.AddUnit("gf2_jpn", new WPos(-7760, 5200), CardinalDirection.East)

					// Yokosuka
					.AddUnit("sp_jpn", new WPos(-7440, 4880), CardinalDirection.East)

					// Osaka
					.AddUnit("ap_jpn", new WPos(-8000, 2800), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 4; i++)
							unit.AddAirplane("g_ft_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_jpn");
					})
					.AddUnit("ct_jpn", new WPos(-8160, 2640), CardinalDirection.East)

					// Kure
					.AddUnit("sp_jpn", new WPos(-8160, 1520), CardinalDirection.East)

					// Kyushu
					.AddUnit("ap_jpn", new WPos(-7600, 960), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 4; i++)
							unit.AddAirplane("ft_jpn");
					})
					.AddUnit("ct_jpn", new WPos(-8320, 640), CardinalDirection.East)

					// Iwo Jima
					.AddUnit("ap_jpn", new WPos(-1520, 4400), CardinalDirection.Northeast, unit =>
					{
						for (var i = 0; i < 5; i++)
							unit.AddAirplane("ft_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("g_ft_jpn");
					})

					// Okinawa
					.AddUnit("ap_jpn", new WPos(-5040, -2800), CardinalDirection.Northeast)

					// Taiwan
					.AddUnit("gf2_jpn", new WPos(-4880, -6880), CardinalDirection.East)

					.AddUnit("cv_jpn", new WPos(-3500, 1500), CardinalDirection.East, unit =>
					{
						for (var i = 0; i < 6; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_jpn");
					})
					.AddUnit("cv_jpn", new WPos(-3650, 1500), CardinalDirection.East, unit =>
					{
						for (var i = 0; i < 4; i++)
							unit.AddAirplane("at_jpn");
					})
					.AddUnit("bb_jpn", new WPos(-3800, 1500), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-3950, 1500), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-4100, 1500), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-4250, 1500), CardinalDirection.East)
					.AddUnit("dd_jpn", new WPos(-4400, 1500), CardinalDirection.East)
					.AddUnit("dd_jpn", new WPos(-4550, 1500), CardinalDirection.East);
			});

			world.AddUnits(world.Players[1], world =>
			{
				world
					// Palau
					.AddUnit("sp_usa", new WPos(6640, -3760), CardinalDirection.East)
					.AddUnit("gf2_usa", new WPos(6560, -3680), CardinalDirection.East)

					.AddUnit("cv_usa", new WPos(8000, -6500), CardinalDirection.West, unit =>
					{
						for (var i = 0; i < 8; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 4; i++)
							unit.AddAirplane("ft_usa");
					})
					.AddUnit("cvl_usa", new WPos(7850, -6500), CardinalDirection.Northwest, unit =>
					{
						for (var i = 0; i < 6; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 2; i++)
							unit.AddAirplane("ft_usa");
					})
					.AddUnit("bb_usa", new WPos(7700, -6500), CardinalDirection.West)
					.AddUnit("bb_usa", new WPos(7550, -6500), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(7400, -6500), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(7250, -6500), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(7100, -6500), CardinalDirection.West)
					.AddUnit("dd_usa", new WPos(6950, -6500), CardinalDirection.West)
					.AddUnit("dd_usa", new WPos(6800, -6500), CardinalDirection.West);
			});
		}
	}
}
