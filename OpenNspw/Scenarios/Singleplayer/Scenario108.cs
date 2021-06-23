﻿using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario108 : SingleplayerScenario
	{
		public Scenario108()
		{
			MapName = "Content/Maps/south_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x423940));

			base.Initialize(world, camera);
		}
	}
}