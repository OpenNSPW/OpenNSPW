using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario3 : SingleplayerScenario
	{
		public Scenario3()
		{
			MapName = "Content/Maps/central_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x42AA60));

			base.Initialize(world, camera);
		}
	}
}
