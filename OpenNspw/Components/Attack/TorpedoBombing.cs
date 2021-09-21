using System;
using System.Collections.Generic;
using System.Linq;
using OpenNspw.Activities;
using OpenNspw.Projectiles;

namespace OpenNspw.Components
{
	internal sealed record TorpedoBombingOptions : PausableConditionalComponentOptions<TorpedoBombing>
	{
		public TorpedoBombingOptions()
		{
			PauseOnCondition = new("hangar");
		}

		public override TorpedoBombing CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class TorpedoBombing : PausableConditionalComponent<TorpedoBombingOptions>, ICreatedEventListener, IUpdatable
	{
		private readonly Lazy<Airplane> _airplane;
		private readonly Lazy<Armament> _armament;

		public TorpedoBombing(Unit self, TorpedoBombingOptions options) : base(self, options)
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

		void IUpdatable.Update(Unit self)
		{
			if (IsDisabled || IsPaused)
				return;

			if (Airplane.Weapon != AirplaneWeapon.Torpedo)
				return;

			if (Armament.Target is not Unit target || !target.CanBeViewedBy(self.Owner))
				return;

			static IEnumerable<CPos> GetAdjacentCells(Map map, WPos value)
			{
				for (var x = -1; x <= 1; x++)
				{
					for (var y = -1; y <= 1; y++)
						yield return map.CellContaining(value) + new CVec(x, y);
				}
			}

			if (GetAdjacentCells(self.World.Map, self.Center).Any(cell => self.World.Map.IsGroundTile(cell)))
				return;

			var (length, angle) = (target.Center + target.Angle.ToVector(target.Speed * Airplane.TorpedoTime) - Self.Center).ToLengthAndAngle();

			if (!angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(45)) || (length is < 100 or > Airplane.TorpedoRange))
				return;

			// TODO

			self.QueueActivity(isQueued: false, new Evade(
				mobile: Airplane,
				speed: Airplane.Speed,
				acceleration: Airplane.Acceleration,
				destination: self.Center + ((self.World.Random.Next(2) == 0)
					? self.Angle + WAngle.FromDegrees(self.World.Random.Next(30, 70))
					: self.Angle - WAngle.FromDegrees(self.World.Random.Next(30, 70))).ToVector(300),
				duration: self.World.Random.Next(20, 320)
			));

			Armament.ClearTarget(clearAmmo: true);

			Airplane.ReturnToBase();
			Airplane.SetWaypoints(self.Center);

			self.World.PlaySound("SoundEffects/spl1", self.Center);

			self.World.Add(new Torpedo(
				center: self.Center,
				angle: self.Angle,
				speed: Airplane.TorpedoSpeed,
				acceleration: 0,
				ticks: 0,
				duration: 240,
				delay: 15
			));
		}
	}
}
