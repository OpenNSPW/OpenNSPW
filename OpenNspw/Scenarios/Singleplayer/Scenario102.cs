using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario102 : SingleplayerScenario
	{
		public Scenario102()
		{
			MapName = "Content/Maps/central_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x41FD60));

			base.Initialize(world, camera);
		}
	}
}
