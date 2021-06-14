using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario106 : SingleplayerScenario
	{
		public Scenario106()
		{
			MapName = "Content/Maps/south_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x421310));

			base.Initialize(world, camera);
		}
	}
}
