using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario204 : SingleplayerScenario
	{
		public Scenario204()
		{
			MapName = "Content/Maps/south_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x4241B0));

			base.Initialize(world, camera);
		}
	}
}
