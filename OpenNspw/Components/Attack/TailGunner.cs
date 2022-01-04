using OpenNspw.Projectiles;

namespace OpenNspw.Components;

internal sealed record TailGunnerOptions : PausableConditionalComponentOptions<TailGunner>
{
	public int Interval { get; init; }
	public string? Sound { get; init; }

	public TailGunnerOptions()
	{
		PauseOnCondition = new("hangar");
	}

	public override TailGunner CreateComponent(Unit self) => new(self, this);
}

internal sealed class TailGunner : PausableConditionalComponent<TailGunnerOptions>, IUpdatable
{
	public TailGunner(Unit self, TailGunnerOptions options) : base(self, options) { }

	void IUpdatable.Update(Unit self)
	{
		if (!self.IsInWorld)
			return;

		if (IsDisabled || IsPaused)
			return;

		var damageFactor = 1/* TODO */;

		if (self.World.Random.Next(Options.Interval * damageFactor) != 0)
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

			if (!angle.IsWithinTolerance(self.Angle + WAngle.FromDegrees(180), WAngle.FromDegrees(30)))
				return false;

			return true;
		}

		var target = self.World.Units/* OPTIMIZE */.FirstOrDefault(u => CanAttack(self, u));

		if (target is null)
			return;

		if (Options.Sound is not null)
			self.World.PlaySound($"SoundEffects/{Options.Sound}", self.Center);

		self.World.Add(new Bullet(
			target: target,
			position: self.Center,
			angle: WAngle.FromVector(target.Center - self.Center) + WAngle.FromDegrees(self.World.Random.Next(-5, 5)),
			speed: 16.0f,
			acceleration: -0.1f,
			terminalSpeed: 14.0f
		));
	}
}
