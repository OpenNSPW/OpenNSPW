using OpenNspw.Projectiles;

namespace OpenNspw.Components
{
	internal sealed record GunshipOptions : PausableConditionalComponentOptions<Gunship>
	{
		public int Interval { get; init; }
		public int Range { get; init; }
		public string? Sound { get; init; }

		public GunshipOptions()
		{
			PauseOnCondition = new("hangar");
		}

		public override Gunship CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Gunship : PausableConditionalComponent<GunshipOptions>, IUpdatable
	{
		public Gunship(Unit self, GunshipOptions options) : base(self, options) { }

		void IUpdatable.Update(Unit self)
		{
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

				return (other.Center - self.Center).Length switch
				{
					<= 100 => self.World.Random.Next(2) == 1,
					<= 300 => self.World.Random.Next(8) == 1,
					_ => false,
				};
			}

			var target = self.World.Units/* OPTIMIZE */.FirstOrDefault(u => CanAttack(self, u));

			if (target is null)
				return;

			if (Options.Sound is not null)
				self.World.PlaySound($"SoundEffects/{Options.Sound}", self.Center);

			self.World.Add(new Bullet(
				target: target,
				position: self.Center,
				angle: WAngle.FromVector(target.Center - self.Center) + WAngle.FromDegrees(self.World.Random.Next(-10, 10)),
				speed: 17.0f,
				acceleration: -0.1f,
				terminalSpeed: 15.0f
			));
		}
	}
}
