using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario304 : SingleplayerScenario
	{
		public Scenario304()
		{
			MapName = "Content/Maps/japan.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x4287E0));

			base.Initialize(world, camera);
		}
	}
}
