﻿namespace OpenNspw.Projectiles
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
			// TODO
		}

		private void Explode(World world)
		{
			Center += Angle.ToVector(Speed);

			// TODO
		}

		public void Update(World world)
		{
			Ticks++;

			if (Target is null && Ticks == 12)
				world.PlaySound("SoundEffects/bomb_off", Center);

			if (Ticks <= Duration)
				Fall(world);
			else
				Explode(world);
		}
	}
}
