using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;

namespace OpenNspw.Tests
{
	internal sealed class FakeAssetManager : IAssetManager
	{
		public IReadOnlyDictionary<string, Texture2D> Textures { get; } = UnitOptions.Components.Keys.ToDictionary(k => $"Textures/Units/{k}", k => (Texture2D)null!);
		public IReadOnlyDictionary<string, SoundEffect> SoundEffects { get; } = new Dictionary<string, SoundEffect>();
	}
}
