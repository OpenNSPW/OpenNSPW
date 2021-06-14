using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario7 : SingleplayerScenario
	{
		public Scenario7()
		{
			MapName = "Content/Maps/south_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x42B8A0));

			base.Initialize(world, camera);
		}
	}
}
