using OpenNspw.Activities;
using OpenNspw.Projectiles;

namespace OpenNspw.Components
{
	internal enum BombingMethod
	{
		Horizontal,
		Dive,
	}

	internal sealed record BombingOptions : PausableConditionalComponentOptions<Bombing>
	{
		public BombingMethod BombingMethod { get; init; }

		public BombingOptions()
		{
			PauseOnCondition = new("hangar");
		}

		public override Bombing CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Bombing : PausableConditionalComponent<BombingOptions>, ICreatedEventListener, IUpdatable
	{
		private readonly Lazy<Airplane> _airplane;
		private readonly Lazy<Armament> _armament;

		public Bombing(Unit self, BombingOptions options) : base(self, options)
		{
			_airplane = new(() => self.GetRequiredComponent<Airplane>());
			_armament = new(() => self.GetRequiredComponent<Armament>());
		}

		private Airplane Airplane => _airplane.Value;
		private Armament Armament => _armament.Value;

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_airplane.ForceInitialize();
			_armament.ForceInitialize();
		}

		private static bool ShouldUpdate(BombingMethod bombingMethod, float length) => bombingMethod switch
		{
			BombingMethod.Horizontal when length is >= 35 and <= 65 => true,
			BombingMethod.Dive when length is >= 170 and <= 180 => true,
			_ => false,
		};

		void IUpdatable.Update(Unit self)
		{
			if (IsDisabled || IsPaused)
				return;

			if (Airplane.Weapon != AirplaneWeapon.Bomb)
				return;

			if (Armament.Target is not Unit target || !target.CanBeViewedBy(self.Owner))
				return;

			var position = target.Center + target.Angle.ToVector(target.Speed * 70.0f);
			var (length, angle) = (position - self.Center).ToLengthAndAngle();

			if (!angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(30)))
				return;

			if (!ShouldUpdate(Options.BombingMethod, length))
				return;

			switch (Options.BombingMethod)
			{
				case BombingMethod.Horizontal:
					self.QueueActivity(isQueued: false, new Evade(
						mobile: Airplane,
						speed: Airplane.Speed,
						acceleration: Airplane.Acceleration,
						destination: self.Center + self.Angle.ToVector(300),
						duration: self.World.Random.Next(150, 200)
					));
					break;

				case BombingMethod.Dive:
					self.QueueActivity(isQueued: false, new Move(
						mobile: Airplane,
						speed: Airplane.Speed + Airplane.Options.Acceleration * 700,
						acceleration: Airplane.Acceleration
					));
					break;
			}

			Armament.ClearTarget(clearAmmo: true);

			Airplane.ReturnToBase();

			switch (Options.BombingMethod)
			{
				case BombingMethod.Horizontal:
					self.World.Add(new GravityBomb(
						target: target,
						center: self.Center + new WVec(self.World.Random.Next(-3, 3), self.World.Random.Next(-3, 3)) + angle.ToVector(13),
						angle: angle,
						speed: 0.3f,
						acceleration: 0.2f,
						ticks: 10,
						duration: 68 + self.World.Random.Next(5)
					));
					self.World.Add(new GravityBomb(
						target: null,
						center: self.Center + new WVec(self.World.Random.Next(-20, 20), self.World.Random.Next(-20, 20)) + angle.ToVector(13),
						angle: angle,
						speed: 0.3f,
						acceleration: 0.2f,
						ticks: 10,
						duration: 75 + self.World.Random.Next(-5, 5)
					));
					break;

				case BombingMethod.Dive:
					self.World.Add(new GravityBomb(
						target: target,
						center: self.Center + new WVec(self.World.Random.Next(-3, 3), self.World.Random.Next(-3, 3)) + angle.ToVector(130),
						angle: angle,
						speed: 0.3f,
						acceleration: 0.2f,
						ticks: 0,
						duration: 70
					));
					self.World.Add(new GravityBomb(
						target: null,
						center: self.Center + new WVec(self.World.Random.Next(-20, 20), self.World.Random.Next(-20, 20)) + angle.ToVector(130),
						angle: angle,
						speed: 0.3f,
						acceleration: 0.2f,
						ticks: 0,
						duration: 70 + self.World.Random.Next(-5, 5)
					));
					break;
			}
		}
	}
}
