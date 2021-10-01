using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario206 : SingleplayerScenario
{
	public Scenario206()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x421A80));

		base.Initialize(world, camera);
	}
}
