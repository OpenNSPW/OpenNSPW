namespace OpenNspw.Scenarios.Multiplayer
{
	internal sealed class Scenario1 : MultiplayerScenario
	{
		public Scenario1()
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

					.AddUnit("cv_jpn", new WPos(-2500, 2500), CardinalDirection.East, unit =>
					{
						for (var i = 0; i < 9; i++)
							unit.AddAirplane("at_jpn");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("ft_jpn");
					})
					.AddUnit("dd_jpn", new WPos(-2620, 2500), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-2740, 2500), CardinalDirection.East)
					.AddUnit("ca_jpn", new WPos(-2860, 2500), CardinalDirection.East);
			});

			world.AddUnits(world.Players[1], world =>
			{
				world
					// Nouméa
					.AddUnit("sp_usa", new WPos(5440, -5760), CardinalDirection.East)
					.AddUnit("gf1_usa", new WPos(5360, -5760), CardinalDirection.East)

					.AddUnit("cv_usa", new WPos(2500, -2500), CardinalDirection.West, unit =>
					{
						for (var i = 0; i < 9; i++)
							unit.AddAirplane("at_usa");
						for (var i = 0; i < 3; i++)
							unit.AddAirplane("ft_usa");
					})
					.AddUnit("dd_usa", new WPos(2650, -2500), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(2800, -2500), CardinalDirection.West)
					.AddUnit("ca_usa", new WPos(2950, -2500), CardinalDirection.West);
			});
		}
	}
}
