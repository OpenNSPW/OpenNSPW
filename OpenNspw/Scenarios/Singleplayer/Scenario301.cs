using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario301 : SingleplayerScenario
{
	public Scenario301()
	{
		MapName = "Content/Maps/south_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x427030));

		base.Initialize(world, camera);
	}
}
