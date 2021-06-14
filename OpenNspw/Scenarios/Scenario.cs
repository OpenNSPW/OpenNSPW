using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace OpenNspw.Scenarios
{
	internal abstract class Scenario
	{
		public sealed record ScenarioPlayer(string Faction, Color Color);

		public string MapName { get; init; } = string.Empty;
		public IReadOnlyList<ScenarioPlayer> Players { get; init; } = new[]
		{
			new ScenarioPlayer("jpn", Color.Red),
			new ScenarioPlayer("usa", Color.Blue),
		};

		public virtual void Initialize(World world, Camera camera) { }
	}
}
