using Microsoft.Xna.Framework;

namespace OpenNspw;

internal sealed class Player
{
	public string Faction { get; }
	public Color Color { get; }

	public Player(string faction, Color color)
	{
		Faction = faction;
		Color = color;
	}

	// TODO: implement
	public bool IsAlliedWith(Player other) => this == other;
}
