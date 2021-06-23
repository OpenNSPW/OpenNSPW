﻿using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario209 : SingleplayerScenario
	{
		public Scenario209()
		{
			MapName = "Content/Maps/central_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x426270));

			base.Initialize(world, camera);
		}
	}
}