using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario200 : SingleplayerScenario
	{
		public Scenario200()
		{
			MapName = "Content/Maps/south_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x421DB0));

			base.Initialize(world, camera);
		}
	}
}
