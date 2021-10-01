using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario107 : SingleplayerScenario
{
	public Scenario107()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x421830));

		base.Initialize(world, camera);
	}
}
