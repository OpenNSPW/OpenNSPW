using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario109 : SingleplayerScenario
	{
		public Scenario109()
		{
			MapName = "Content/Maps/japan.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x424DD0));

			base.Initialize(world, camera);
		}
	}
}
