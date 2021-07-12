using System;
using OpenNspw.Activities;

namespace OpenNspw.Components
{
	internal sealed record ReturnToBaseOptions : ConditionalComponentOptions<ReturnToBase>
	{
		public ReturnToBaseOptions()
		{
			RequiresCondition = new("leader && approach");
		}

		public override ReturnToBase CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class ReturnToBase : ConditionalComponent<ReturnToBaseOptions>, ICreatedEventListener, IArrivalEventListener, IUpdatable
	{
		private readonly Lazy<Airplane> _airplane;

		public ReturnToBase(Unit self, ReturnToBaseOptions options) : base(self, options)
		{
			_airplane = new(() => self.GetRequiredComponent<Airplane>());
		}

		private Airplane Airplane => _airplane.Value;

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_airplane.ForceInitialize();
		}

		private void SetLandingWaypoints(int count)
		{
			if (Airplane.Hangar is not Hangar hangar || hangar.Self.IsDead)
			{
				Airplane.Waypoints.Clear();
				Airplane.Waypoints.Add(Airplane.Center + new WVec(Self.World.Random.Next(-200, 200), Self.World.Random.Next(-200, 200)));
			}
			else
				Airplane.SetWaypoints(Airplane.GetLandingWaypoints(hangar, count));
		}

		void IArrivalEventListener.OnArrival(Unit self)
		{
			if (Airplane.FlightMode == FlightMode.ReturnToBase)
				SetLandingWaypoints(count: 4);
		}

		void IUpdatable.Update(Unit self)
		{
			if (IsDisabled)
				return;

			SetLandingWaypoints(count: Airplane.Waypoints.Count);

			if (Airplane.CanLand)
				self.QueueActivity(isQueued: false, new Land(Airplane, Airplane.Hangar));
		}
	}
}
