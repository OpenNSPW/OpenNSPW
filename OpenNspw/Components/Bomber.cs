using System;
using System.Linq;
using OpenNspw.Activities;

namespace OpenNspw.Components
{
	internal sealed record BomberOptions : IComponentOptions<Bomber>
	{
		public Bomber CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Bomber : IComponent<BomberOptions>, ICreatedEventListener, IUpdatable
	{
		public Unit Self { get; }
		public BomberOptions Options { get; }

		private readonly Lazy<Airplane> _airplane;
		private readonly Lazy<Armament> _armament;

		public Bomber(Unit self, BomberOptions options)
		{
			Self = self;
			Options = options;

			_airplane = new(() => self.GetRequiredComponent<Airplane>());
			_armament = new(() => self.GetRequiredComponent<Armament>());
		}

		public Airplane Airplane => _airplane.Value;
		public Armament Armament => _armament.Value;

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_armament.ForceInitialize();
		}

		void IUpdatable.Update(Unit self)
		{
			if (Armament.Target is not Unit target || !Airplane.IsLeader) return;

			var (distance, angle) = (target.Center - self.Center).ToLengthAndAngle();

			switch (distance)
			{
				case >= 500 and <= 510 when angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(22.5f)):
					foreach (var follower in Airplane.Followers.Where(f => f.Self.HasComponent<Bomber>()/* TODO */).ToArray())
					{
						angle = (follower.PositionNumber % 5) switch
						{
							0 => follower.Angle,
							1 => follower.Angle + WAngle.FromDegrees(315 + 22.5f),
							2 => follower.Angle + WAngle.FromDegrees(22.5f),
							3 => follower.Angle + WAngle.FromDegrees(315),
							4 => follower.Angle + WAngle.FromDegrees(45),
							_ => throw new InvalidOperationException(),
						};
						follower.Self.QueueActivity(isQueued: false, new Evade(
							mobile: follower,
							speed: follower.Speed,
							acceleration: follower.Acceleration,
							destination: follower.Center + angle.ToVector(600),
							duration: 10 + ((1 + (follower.PositionNumber % 5)) * 20
						)));
						follower.SetWaypoints(target.Center);
						follower.ClearLeader();
					}
					break;

				case >= 400:
					if (Airplane.Waypoints.Count == 1)
					{
						if (WRect.FromCenter(Airplane.Waypoints.First(), new WVec(70, 70)).Contains(self.Center) && target.CanBeViewedBy(self.Owner))
							Airplane.SetWaypoints(target.Center + target.Angle.ToUnitVector());
					}
					break;

				case >= 40 when angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(45)):
					if (Airplane.Waypoints.Count == 1)
					{
						var time = Airplane.Weapon == AirplaneWeapon.Torpedo ? (Airplane.TorpedoRange / Airplane.TorpedoSpeed) : 70.0f;
						Airplane.SetWaypoints(target.Center + target.Angle.ToVector(target.Speed * time));

						foreach (var follower in Airplane.Followers.Where(f => f.Self.HasComponent<Bomber>()).ToArray())
							follower.ClearLeader();
					}
					break;

				default:
					if (WRect.FromCenter(Airplane.Waypoints.First(), new WVec(70, 70)).Contains(self.Center))
						Airplane.SetWaypoints(self.Center + self.Angle.ToVector(300));
					break;
			}
		}
	}
}
