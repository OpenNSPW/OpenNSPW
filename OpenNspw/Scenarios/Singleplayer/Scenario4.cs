using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario4 : SingleplayerScenario
	{
		public Scenario4()
		{
			MapName = "Content/Maps/south_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x42AC90));

			base.Initialize(world, camera);
		}
	}
}
