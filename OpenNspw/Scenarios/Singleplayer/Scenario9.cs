using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario9 : SingleplayerScenario
{
	public Scenario9()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x42CED0));

		base.Initialize(world, camera);
	}
}
