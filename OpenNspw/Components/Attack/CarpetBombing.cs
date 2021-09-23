using System;
using System.Linq;
using OpenNspw.Projectiles;

namespace OpenNspw.Components
{
	internal sealed record CarpetBombingOptions : PausableConditionalComponentOptions<CarpetBombing>
	{
		public int Interval { get; init; }

		public CarpetBombingOptions()
		{
			PauseOnCondition = new("hangar");
		}

		public override CarpetBombing CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class CarpetBombing : PausableConditionalComponent<CarpetBombingOptions>, IUpdatable, ICreatedEventListener
	{
		public int ReloadDelay { get; private set; }

		private readonly Lazy<Airplane> _airplane;
		private readonly Lazy<Armament> _armament;

		public CarpetBombing(Unit self, CarpetBombingOptions options) : base(self, options)
		{
			_airplane = new(() => self.GetRequiredComponent<Airplane>());
			_armament = new(() => self.GetRequiredComponent<Armament>());
		}

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_airplane.ForceInitialize();
			_armament.ForceInitialize();
		}

		private Airplane Airplane => _airplane.Value;
		private Armament Armament => _armament.Value;

		void IUpdatable.Update(Unit self)
		{
			if (IsDisabled || IsPaused)
				return;

			if (Airplane.Weapon != AirplaneWeapon.Bomb)
				return;

			if (ReloadDelay >= 1)
			{
				ReloadDelay--;

				if (ReloadDelay != 0)
					return;
			}

			static bool CanAttack(Unit self, Unit other)
			{
				if (other.IsDead)
					return false;

				// TODO

				if (other.Owner.IsAlliedWith(self.Owner))
					return false;

				if (!other.CanBeViewedBy(self.Owner))
					return false;

				var (length, angle) = (other.Center - self.Center).ToLengthAndAngle();

				if (length is < 30 or > 60)
					return false;

				if (!angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(30)))
					return false;

				return true;
			}

			var target = (Armament.Target is not null)
				? (CanAttack(self, Armament.Target) ? Armament.Target : null)
				: self.World.Units/* OPTIMIZE */.FirstOrDefault(u => CanAttack(self, u));

			if (target is null)
				return;

			self.World.PlaySound("SoundEffects/bb_bomb", self.Center);

			ReloadDelay = Options.Interval;

			self.World.Add(new GravityBomb(
				target: null,
				center: self.Center + new WVec(self.World.Random.Next(-6, 7), self.World.Random.Next(-6, 7)),
				angle: WAngle.FromVector(target.Center - self.Center) + WAngle.FromDegrees(self.World.Random.Next(-5, 5)),
				speed: 0.3f,
				acceleration: 0.2f,
				ticks: 0,
				duration: 70
			));
		}
	}
}
