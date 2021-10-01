using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario207 : SingleplayerScenario
{
	public Scenario207()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x425D60));

		base.Initialize(world, camera);
	}
}
