using OpenNspw.Effects;

namespace OpenNspw.Projectiles;

internal sealed class DepthCharge : IProjectile
{
	public int Ticks { get; private set; }
	public int Duration { get; }
	public WPos Center { get; }

	public DepthCharge(WPos center, int duration)
	{
		Center = center;
		Duration = duration;
	}

	public void Update(World world)
	{
		Ticks++;

		if (Ticks == 5)
		{
			world.Add(new SpriteEffect(
				layer: EffectLayer.Lower,
				name: "Textures/Effects/effect_7",
				duration: 30,
				mode: SpriteEffectMode.Four,
				center: Center,
				frame: 0
			));
		}

		if (Ticks == Duration)
		{
			world.Add(new SpriteEffect(
				layer: EffectLayer.Lower,
				name: "Textures/Effects/effect_11",
				duration: 40,
				mode: SpriteEffectMode.Four,
				center: Center,
				frame: 0
			));

			world.PlaySound("SoundEffects/tpd_hit1", Center);

			// TODO

			world.AddFrameEndAction(w => w.Remove(this));
		}
	}
}
