using Microsoft.Xna.Framework.Audio;

namespace OpenNspw
{
	internal sealed class Sound : IDisposable
	{
		private sealed class SoundEffectInstancePool : IDisposable
		{
			private const int MaxInstances = 6;
			private readonly SoundEffectInstance[] _instances = new SoundEffectInstance[MaxInstances];

			private int _currentIndex;

			public SoundEffectInstancePool(SoundEffect soundEffect)
			{
				for (var i = 0; i < _instances.Length; i++)
					_instances[i] = soundEffect.CreateInstance();
			}

			private SoundEffectInstance CurrentInstance => _instances[_currentIndex];

			public void Dispose()
			{
				foreach (var instance in _instances)
					instance.Dispose();
			}

			public void Play()
			{
				try
				{
					CurrentInstance.Stop();
					CurrentInstance.Play();
					_currentIndex = (_currentIndex + 1) % _instances.Length;
				}
				catch (InstancePlayLimitException) { }
			}
		}

		private readonly IReadOnlyDictionary<string, SoundEffectInstancePool> _pools;

		public Sound(IAssetManager assets)
		{
			_pools = new Dictionary<string, SoundEffectInstancePool>(assets.SoundEffects.ToDictionary(kv => kv.Key, kv => new SoundEffectInstancePool(kv.Value)));
		}

		public void Dispose()
		{
			foreach (var value in _pools.Values)
				value.Dispose();
		}

		public void Play(string name) => _pools[name].Play();
	}
}
