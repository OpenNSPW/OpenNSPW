using System.Linq;
using OpenNspw.Components;
using OpenNspw.Effects;

namespace OpenNspw.Projectiles
{
	internal sealed class Torpedo : IProjectile
	{
		public int Ticks { get; private set; }
		public int Duration { get; }
		public int Delay { get; }
		public WPos Center { get; private set; }
		public WAngle Angle { get; }
		public float Speed { get; private set; }
		public float Acceleration { get; }

		public Torpedo(WPos center, WAngle angle, float speed, float acceleration, int ticks, int duration, int delay)
		{
			Center = center;
			Angle = angle;
			Speed = speed;
			Acceleration = acceleration;
			Ticks = ticks;
			Duration = duration;
			Delay = delay;
		}

		private float PreviousSpeed => Speed - Acceleration;
		private WPos PreviousCenter => Center - Angle.ToVector(PreviousSpeed);

		public void Update(World world)
		{
			if (Ticks > Duration)
			{
				world.AddFrameEndAction(w => w.Remove(this));
				return;
			}

			if (world.Map.IsGroundTile(Center + Angle.ToVector(-40)))
				Ticks = Duration;

			Center += Angle.ToVector(Speed);
			Speed += Acceleration;

			var victim = (Ticks >= Delay)
				? world.Units.FirstOrDefault(u => !u.IsDead && !u.Submerged && u.HasComponent<Ship>() && u.Contains(Center))
				: null;

			if (victim is not null)
			{
				world.AddFrameEndAction(w => w.Remove(this));

				// TODO

				world.PlaySound((world.Random.Next(2) == 0) ? "SoundEffects/tpd_hit1" : "SoundEffects/tpd_hit2", Center);

				world.Add(new SpriteEffect(
					layer: EffectLayer.Lower,
					name: "Textures/Effects/effect_11",
					duration: 40,
					mode: SpriteEffectMode.Four,
					center: Center,
					frame: 0
				));
			}
			else
			{
				Ticks++;

				if (Ticks == 1)
				{
					world.Add(new SpriteEffect(
						layer: EffectLayer.Lower,
						name: "Textures/Effects/effect_8",
						duration: 30,
						mode: SpriteEffectMode.Zero,
						center: Center,
						frame: 0
					));
				}

				if (Ticks >= Delay)
				{
					world.Add(new SpriteEffect(
						layer: EffectLayer.Lower,
						name: "Textures/Effects/effect_72",
						duration: 1,
						mode: SpriteEffectMode.Zero,
						center: Center,
						frame: Angle.Quantize()
					));

					if ((world.WorldTick % 3) == 0)
					{
						world.Add(new SpriteEffect(
							layer: EffectLayer.Lower,
							name: "Textures/Effects/effect_8",
							duration: world.LocalRandom.Next(30, 55),
							mode: SpriteEffectMode.Four,
							center: PreviousCenter + new WVec(world.LocalRandom.Next(-5, 5), world.LocalRandom.Next(-5, 5)),
							frame: 0
						));
					}
				}
			}
		}
	}
}
