using System.Linq;
using OpenNspw.Effects;

namespace OpenNspw.Projectiles
{
	internal sealed class GravityBomb : IProjectile
	{
		public Unit? Target { get; }
		public int Ticks { get; private set; }
		public int Duration { get; }
		public WPos Center { get; private set; }
		public WAngle Angle { get; }
		public float Speed { get; private set; }
		public float Acceleration { get; }

		public GravityBomb(Unit? target, WPos center, WAngle angle, float speed, float acceleration, int ticks, int duration)
		{
			Target = target;
			Center = center;
			Angle = angle;
			Speed = speed;
			Acceleration = acceleration;
			Ticks = ticks;
			Duration = duration;
		}

		private void Fall(World world)
		{
			if (Ticks < 50)
				return;

			if (Ticks == 50)
				world.PlaySound("SoundEffects/fall1", Center);

			Center += Angle.ToVector(Speed);
			Speed += Acceleration;

			world.Add(new SpriteEffect(
				layer: EffectLayer.Upper,
				name: "Textures/Effects/effect_84",
				duration: 1,
				mode: SpriteEffectMode.Zero,
				center: Center,
				frame: Angle.Quantize()
			));
		}

		private void Explode(World world)
		{
			Center += Angle.ToVector(Speed);

			world.AddFrameEndAction(w => w.Remove(this));

			var victim = world.Units.FirstOrDefault(u => !u.IsDead && !u.Submerged && u.Contains(Center));

			if (victim is not null)
			{
				// TODO

				world.Add(new SpriteEffect(
					layer: EffectLayer.Upper,
					name: "Textures/Effects/effect_1",
					duration: 40,
					mode: SpriteEffectMode.Four,
					center: Center,
					frame: 0
				));
				world.PlaySound((world.Random.Next(2) == 0) ? "SoundEffects/bom_hit1" : "SoundEffects/bom_hit2", Center);
			}
			else
			{
				if (world.Map.IsGroundTile(Center))
				{
					world.Add(new SpriteEffect(
						layer: EffectLayer.Lower,
						name: "Textures/Effects/effect_10",
						duration: 40,
						mode: SpriteEffectMode.Four,
						center: Center,
						frame: 0
					));
					world.PlaySound("SoundEffects/bom_hit1", Center);
				}
				else
				{
					world.Add(new SpriteEffect(
						layer: EffectLayer.Lower,
						name: "Textures/Effects/effect_8",
						duration: 40,
						mode: SpriteEffectMode.Four,
						center: Center,
						frame: 0
					));
					world.PlaySound("SoundEffects/spl1", Center);
				}
			}
		}

		public void Update(World world)
		{
			Ticks++;

			if (Target is not null && Ticks == 12)
				world.PlaySound("SoundEffects/bomb_off", Center);

			if (Ticks <= Duration)
				Fall(world);
			else
				Explode(world);
		}
	}
}
