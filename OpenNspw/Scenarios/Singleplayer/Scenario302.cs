using Aigamo.Enzan;

namespace OpenNspw.Scenarios.Singleplayer;

internal sealed class Scenario302 : SingleplayerScenario
{
	public Scenario302()
	{
		MapName = "Content/Maps/central_pacific.dat";
	}

	public override void Initialize(World world, Camera camera)
	{
		Emulator.Call(new Register32(0x4278B0));

		base.Initialize(world, camera);
	}
}
