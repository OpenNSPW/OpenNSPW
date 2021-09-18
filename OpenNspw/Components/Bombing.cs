using System;
using System.Linq;
using OpenNspw.Activities;

namespace OpenNspw.Components
{
	internal enum BombingMethod
	{
		Horizontal,
		Dive,
	}

	internal sealed record BombingOptions : IComponentOptions<Bombing>
	{
		public BombingMethod BombingMethod { get; init; }

		public Bombing CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Bombing : IComponent<BombingOptions>, ICreatedEventListener, IUpdatable
	{
		public Unit Self { get; }
		public BombingOptions Options { get; }

		private readonly Lazy<Airplane> _airplane;
		private readonly Lazy<Armament> _armament;

		public Bombing(Unit self, BombingOptions options)
		{
			Self = self;
			Options = options;

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
			Airplane.FlightMode = FlightMode.ReturnToBase;

			foreach (var follower in Airplane.Followers.OfType<Airplane>().Where(f => !f.IsInHangar).ToArray())
			{
				follower.ClearLeader();
				follower.FlightMode = FlightMode.ReturnToBase;
				follower.SetWaypoints(self.Center);
			}

			switch (Options.BombingMethod)
			{
				case BombingMethod.Horizontal:
					// TODO
					break;

				case BombingMethod.Dive:
					// TODO
					break;
			}
		}
	}
}
