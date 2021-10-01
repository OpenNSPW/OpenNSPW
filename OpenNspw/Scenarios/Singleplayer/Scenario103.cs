using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario103 : SingleplayerScenario
{
	public Scenario103()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x420260));

		base.Initialize(world, camera);
	}
}
