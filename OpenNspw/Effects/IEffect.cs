using Aigamo.Saruhashi;

namespace OpenNspw.Effects
{
	internal enum EffectLayer
	{
		Lower,
		Upper,
	}

	internal interface IEffect
	{
		EffectLayer Layer { get; }

		void Update(World world);
		void Draw(World world, Graphics graphics);
	}
}
