using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario202 : SingleplayerScenario
	{
		public Scenario202()
		{
			MapName = "Content/Maps/japan.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x422D10));

			base.Initialize(world, camera);
		}
	}
}
