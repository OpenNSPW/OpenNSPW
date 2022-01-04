using OpenNspw.Projectiles;

namespace OpenNspw.Components;

internal sealed record WingGunOptions : PausableConditionalComponentOptions<WingGun>
{
	public int Interval { get; init; }
	public string? Sound { get; init; }

	public WingGunOptions()
	{
		PauseOnCondition = new("hangar");
	}

	public override WingGun CreateComponent(Unit self) => new(self, this);
}

internal sealed class WingGun : PausableConditionalComponent<WingGunOptions>, IUpdatable
{
	public int Timing { get; }

	public WingGun(Unit self, WingGunOptions options) : base(self, options)
	{
		Timing = self.World.Random.Next(20);
	}

	void IUpdatable.Update(Unit self)
	{
		if (!self.IsInWorld)
			return;

		if (IsDisabled || IsPaused)
			return;

		if (((self.World.WorldTick + Timing) % Options.Interval) != 0)
			return;

		static bool CanAttack(Unit self, Unit other)
		{
			if (!other.CanBeViewedBy(self.Owner))
				return false;

			if (other.IsDead)
				return false;

			if (other.Owner.IsAlliedWith(self.Owner))
				return false;

			var (length, angle) = (other.Center - self.Center).ToLengthAndAngle();

			if (length > 300)
				return false;

			if (!angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(10)))
				return false;

			return true;
		}

		var target = self.World.Units/* OPTIMIZE */.FirstOrDefault(u => CanAttack(self, u));

		if (target is null)
			return;

		// TODO: consume ammo

		if (Options.Sound is not null)
			self.World.PlaySound($"SoundEffects/{Options.Sound}", self.Center);

		self.World.Add(new Bullet(
			target: target,
			position: self.Center,
			angle: self.Angle,
			speed: 16.0f,
			acceleration: -0.1f,
			terminalSpeed: 14.0f
		));
	}
}
