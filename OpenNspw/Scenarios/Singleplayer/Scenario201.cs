using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer
{
	internal sealed class Scenario201 : SingleplayerScenario
	{
		public Scenario201()
		{
			MapName = "Content/Maps/central_pacific.dat";
		}

		public override void Initialize(World world, Camera camera)
		{
			Emulator.Call(new Register32(0x422820));

			base.Initialize(world, camera);
		}
	}
}
