using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using OpenNspw.Activities;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal sealed record AirplaneOptions : MobileOptions<Airplane>
	{
		public float LandingDistance { get; init; }
		public string? ApproachCondition { get; init; } = "approach";
		public string? HangarCondition { get; init; } = "hangar";

		public override Airplane CreateComponent(Unit self) => new(self, this);
	}

	internal enum FlightMode
	{
		Cruise,
		ReturnToBase,
	}

	internal sealed class Airplane : Mobile<AirplaneOptions>, IAddedToWorldEventListener, IRemovedFromWorldEventListener, IOrderHandler
	{
		public Hangar? Hangar { get; set; }
		public FlightMode FlightMode { get; set; }

		[MemberNotNullWhen(true, nameof(Hangar))]
		public bool IsInHangar { get; private set; }

		public ConditionToken ApproachToken { get; private set; }
		public ConditionToken HangarToken { get; private set; }

		public Airplane(Unit self, AirplaneOptions options) : base(self, options) { }

		public bool CanTakeOff => Hangar?.AllowTakeoff ?? false;

		[MemberNotNullWhen(true, nameof(Hangar))]
		public bool CanLand
		{
			get
			{
				if (Hangar is null)
					return false;

				if (!Hangar.AllowLanding)
					return false;

				if (Angle.Quantize() != Hangar.Self.Angle.Quantize())
					return false;

				return WRect.FromCenter(Hangar.Self.Center, new WVec(40, 40)).Contains(Center);
			}
		}

		protected override float GetAcceleration(WAngle desiredAngle)
		{
			var acceleration = Options.Acceleration;

			if (Angle.IsWithinTolerance(desiredAngle, angleTolerance: WAngle.FromDegrees(45.0f)))
				return (Speed > GetMaxSpeed() / 3 * 2) ? -acceleration : acceleration;

			return (Speed > GetMaxSpeed() / 2) ? -acceleration : acceleration;
		}

		void IAddedToWorldEventListener.OnAddedToWorld(Unit self)
		{
			IsInHangar = false;

			if (HangarToken.IsValid)
				HangarToken = self.RevokeCondition(HangarToken);
		}

		private void CancelApproachClearance()
		{
			if (ApproachToken.IsValid)
				ApproachToken = Self.RevokeCondition(ApproachToken);
		}

		void IRemovedFromWorldEventListener.OnRemovedFromWorld(Unit self)
		{
			CancelApproachClearance();

			IsInHangar = true;

			if (!HangarToken.IsValid)
				HangarToken = self.GrantCondition(Options.HangarCondition);
		}

		public override void HandleOrder(World world, IOrder order)
		{
			base.HandleOrder(world, order);

			switch (order)
			{
				case WaypointOrder:
					CancelApproachClearance();

					if (IsInHangar)
					{
						Self.QueueActivity(isQueued: false, new TakeOff(this, Hangar));
						Self.QueueActivity(new Move(this, speed: 0, acceleration: 0));
					}
					break;

				case FlightModeOrder flightModeOrder:
					CancelApproachClearance();

					FlightMode = flightModeOrder.FlightMode;
					break;
			}
		}

		public override void OnArrival()
		{
			base.OnArrival();

			if (FlightMode == FlightMode.ReturnToBase)
			{
				if (!ApproachToken.IsValid)
					ApproachToken = Self.GrantCondition(Options.ApproachCondition);

				foreach (var follower in Followers.ToArray())
					(follower as Airplane)?.Scatter();
			}
		}

		private static WAngle GetFlightAngle(int number, WAngle angle) => (number % 5) switch
		{
			0 => WAngle.Zero,
			1 => angle - WAngle.FromDegrees(90.0f + 45.0f),
			2 => angle - WAngle.FromDegrees(90.0f + 45.0f + 90.0f),
			3 => angle - WAngle.FromDegrees(90.0f + 45.0f),
			4 => angle - WAngle.FromDegrees(90.0f + 45.0f + 90.0f),
			5 => angle - WAngle.FromDegrees(90.0f + 45.0f + 45.0f),
			_ => WAngle.Zero
		};

		private static float GetFlightDistance(int number) => (number % 5) switch
		{
			0 => 0,
			1 => 60 * 0.80f,
			2 => 60 * 0.80f,
			3 => 120 * 0.80f,
			4 => 120 * 0.80f,
			5 => 100 * 0.80f,
			_ => 0
		};

		private static WVec GetFlightVector(int number, WAngle angle) => GetFlightAngle(number, angle).ToVector(GetFlightDistance(number));

		private static WAngle GetSquadronAngle(int number, WAngle angle) => (number / 5) switch
		{
			0 => angle,
			1 => angle - WAngle.FromDegrees(90.0f + 45.0f),
			2 => angle - WAngle.FromDegrees(90.0f + 45.0f + 90.0f),
			3 => angle - WAngle.FromDegrees(90.0f + 45.0f),
			4 => angle - WAngle.FromDegrees(90.0f + 45.0f + 45.0f),
			5 => angle - WAngle.FromDegrees(90.0f + 45.0f + 90.0f),
			6 => angle - WAngle.FromDegrees(90.0f + 45.0f),
			7 => angle - WAngle.FromDegrees(90.0f + 45.0f + 22.5f),
			8 => angle - WAngle.FromDegrees(90.0f + 45.0f + 45.0f + 22.5f),
			9 => angle - WAngle.FromDegrees(90.0f + 45.0f + 90.0f),
			10 => angle - WAngle.FromDegrees(90.0f + 45.0f + 11.2f),
			11 => angle - WAngle.FromDegrees(90.0f + 45.0f + 90.0f - 11.2f),
			_ => WAngle.Zero
		};

		private static float GetSquadronDistance(int number) => (number / 5) switch
		{
			0 => 35,
			1 => 180 * 0.80f,
			2 => 180 * 0.80f,
			3 => 360 * 0.80f,
			4 => 300 * 0.80f,
			5 => 360 * 0.80f,
			6 => 540 * 0.80f,
			7 => 480 * 0.80f,
			8 => 480 * 0.80f,
			9 => 540 * 0.80f,
			10 => 640 * 0.80f,
			11 => 640 * 0.80f,
			_ => 0
		};

		private static WVec GetSquadronVector(int number, WAngle angle) => GetSquadronAngle(number, angle).ToVector(GetSquadronDistance(number));

		public override void UpdateFormation(Mobile leader, int positionNumber)
		{
			switch (leader)
			{
				case Ship:
					{
						var angle = WAngle.FromDegrees(Self.World.Random.Next(360));
						var distance = Self.World.Random.Next(650);
						// TODO
						Waypoints.Clear();
						Waypoints.Add(leader.Center + angle.ToVector(distance));
						break;
					}

				case Airplane:
					{
						var waypoint = leader.Center + GetFlightVector(positionNumber, leader.Angle);
						Waypoints[0] = waypoint;

						if (positionNumber / 5 >= 0)
						{
							Waypoints.Clear();
							Waypoints.Add(waypoint + GetSquadronVector(positionNumber, leader.Angle));
						}
						break;
					}
			}
		}

		public void Fold()
		{
			if (Self.World.Assets.Textures.TryGetValue($"Textures/Units/{Self.Name}_folded", out var texture))
				Self.Texture = texture;
		}

		public void Unfold()
		{
			Self.Texture = Self.World.Assets.Textures[$"Textures/Units/{Self.Name}"];
		}

		public void Scatter()
		{
			ClearLeader();

			var waypoint = Waypoints.First();
			Waypoints.Clear();
			Waypoints.Add(waypoint + new WVec(Self.World.Random.Next(-300, 300), Self.World.Random.Next(-300, 300)));
		}

		public IEnumerable<WPos> GetLandingWaypoints(Hangar hangar, int count)
		{
			var angle = WAngle.FromFacing(hangar.Self.Angle.Facing) - WAngle.FromDegrees(180);
			if (count >= 4) yield return hangar.Self.Center + angle.ToVector(Options.LandingDistance);
			if (count >= 3) yield return hangar.Self.Center + angle.ToVector(130);
			if (count >= 2) yield return hangar.Self.Center + angle.ToVector(10);
			if (count >= 1) yield return hangar.Self.Center + WAngle.FromFacing(hangar.Self.Angle.Facing).ToVector(100);
		}
	}
}
