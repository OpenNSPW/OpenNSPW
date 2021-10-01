using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario305 : SingleplayerScenario
{
	public Scenario305()
	{
		MapName = "Content/Maps/japan.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x428C60));

		base.Initialize(world, camera);
	}
}
