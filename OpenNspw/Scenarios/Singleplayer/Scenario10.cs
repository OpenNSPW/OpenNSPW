using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario10 : SingleplayerScenario
	{
		public Scenario10()
		{
			MapName = "Content/Maps/japan.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x42D3C0));

			base.Initialize(world, camera);
		}
	}
}
