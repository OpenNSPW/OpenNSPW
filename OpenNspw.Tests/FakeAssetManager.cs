using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace OpenNspw.Tests;

internal sealed class FakeAssetManager : IAssetManager
{
	public IReadOnlyDictionary<string, Texture2D> Textures { get; } = UnitOptions.Components.Keys
		.Concat(new[]
		{
			"ft_usa_folded",
			"at_usa_folded",
		})
		.ToDictionary(k => $"Textures/Units/{k}", k => (Texture2D)null!);

	public IReadOnlyDictionary<string, SoundEffect> SoundEffects { get; } = new Dictionary<string, SoundEffect>();
}
