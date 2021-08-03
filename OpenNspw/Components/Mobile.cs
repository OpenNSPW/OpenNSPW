using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using OpenNspw.Activities;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal abstract record MobileOptions : IComponentOptions<Mobile>
	{
		public WAngle TurnSpeed { get; init; }
		public float Acceleration { get; init; }
		public float MinSpeed { get; init; }
		public float MaxSpeed { get; init; }
		public HashSet<short> TerrainTypes { get; init; } = new();
		public bool StopOnArrival { get; init; }
		public string? LeaderCondition { get; init; } = "leader";
		public string? FollowerCondition { get; init; } = "follower";

		public abstract Mobile CreateComponent(Unit self);
	}

	internal abstract record MobileOptions<TComponent> : MobileOptions
		where TComponent : Mobile
	{
		public abstract override TComponent CreateComponent(Unit self);
	}

	// TODO: rename
	internal enum FormationState
	{
		Zero,
		One,
		Two,
	}

	internal abstract class Mobile : IComponent<MobileOptions>, IUnit, ICreatedEventListener, IOrderHandler
	{
		public Unit Self { get; }
		public MobileOptions Options { get; }
		public WPos Center { get; set; }
		public WAngle Angle { get; set; }
		public WAngle TurnSpeed { get; set; }
		public bool Stop { get; set; } = true;
		public List<WPos> Waypoints { get; } = new();
		public List<Mobile> Followers { get; } = new();
		public Mobile? Leader { get; private set; }
		public int PositionNumber { get; private set; }
		public FormationState FormationState { get; set; }
		public float FormationSpeed { get; set; }
		public ConditionToken LeaderToken { get; private set; }
		public ConditionToken FollowerToken { get; private set; }

		private readonly Lazy<IArrivalEventListener[]> _arrivalEventListeners;

		protected Mobile(Unit self, MobileOptions options)
		{
			Self = self;
			Options = options;

			_arrivalEventListeners = new(() => self.Components.OfType<IArrivalEventListener>().ToArray());
		}

		IEnumerable<WPos> IUnit.Waypoints => Waypoints;

		public float Speed => (Self.CurrentActivity as IMove)?.Speed ?? 0;
		public float Acceleration => (Self.CurrentActivity as IMove)?.Acceleration ?? 0;

		[MemberNotNullWhen(false, nameof(Leader))]
		public bool IsLeader => Leader is null;

		private IArrivalEventListener[] ArrivalEventListeners => _arrivalEventListeners.Value;

		public virtual bool CanMove(WPos position)
		{
			if (!Self.World.Map.Contains(position))
				return true;

			if (!Options.TerrainTypes.Any())
				return true;

			var terrainType = Self.World.Map.Tiles[Self.World.Map.CellContaining(position)];
			return Options.TerrainTypes.Contains(terrainType);
		}

		public WAngle GetTurnSpeed(WAngle angle) => angle.Degrees switch
		{
			>= 1.0f and <= 3.0f => WAngle.FromDegrees(0.5f),
			> 3.0f and <= 180.0f => Options.TurnSpeed,
			> 180.0f and < 357.0f => -Options.TurnSpeed,
			>= 357.0f and <= 359.0f => -WAngle.FromDegrees(0.5f),
			_ => WAngle.Zero,
		};

		public float GetMaxSpeed() => Options.MaxSpeed/* TODO: apply modifier */;

		public float GetSpeed(float acceleration)
		{
			var speed = Speed + acceleration;
			var maxSpeed = GetMaxSpeed();
			if (speed > maxSpeed)
			{
				speed -= Options.Acceleration * 8;
				if (speed < maxSpeed)
					speed = maxSpeed;
			}

			// TODO: apply modifiers

			return speed;
		}

		protected virtual float GetAcceleration(WAngle desiredAngle) => Options.Acceleration;

		public float GetAcceleration(bool keepFormation, WAngle desiredAngle)
		{
			var acceleration = Options.Acceleration;

			if (Angle.IsWithinTolerance(desiredAngle, angleTolerance: WAngle.FromDegrees(22.5f)))
			{
				if (!keepFormation)
					return acceleration;

				return FormationState switch
				{
					FormationState.One => (true/* TODO */ && Speed >= FormationSpeed * 0.60f/* TODO */ + acceleration) ? -acceleration : acceleration,
					FormationState.Two when Options.MaxSpeed >= Leader?.Options.MaxSpeed => 0,
					_ => acceleration,
				};
			}

			return GetAcceleration(desiredAngle);
		}

		public void SetWaypoints(IEnumerable<WPos> waypoints)
		{
			Waypoints.Clear();
			Waypoints.AddRange(waypoints);
		}

		protected virtual void OnLeaderChanged(Unit self, Mobile? oldLeader, Mobile? newLeader) { }

		private void SetLeader(Mobile? leader)
		{
			if (leader is null)
			{
				if (!LeaderToken.IsValid)
					LeaderToken = Self.GrantCondition(Options.LeaderCondition);

				if (FollowerToken.IsValid)
					FollowerToken = Self.RevokeCondition(FollowerToken);
			}
			else
			{
				if (LeaderToken.IsValid)
					LeaderToken = Self.RevokeCondition(LeaderToken);

				if (!FollowerToken.IsValid)
					FollowerToken = Self.GrantCondition(Options.FollowerCondition);
			}

			if (leader == Leader)
				return;

			foreach (var follower in Followers.ToArray())
				follower.ClearLeader();

			Leader?.Followers.Remove(this);
			leader?.Followers.Add(this);

			var oldLeader = Leader;
			Leader = leader;

			OnLeaderChanged(Self, oldLeader, leader);
		}

		protected virtual void ClearLeader()
		{
			SetLeader(null);
			PositionNumber = 0;
		}

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_arrivalEventListeners.ForceInitialize();

			ClearLeader();
			Waypoints.Add(Center);
		}

		private void HandleOrder(World world, WaypointOrder waypointOrder)
		{
			var mobiles = waypointOrder.Selection
				.Select(u => u.Components.OfType<Mobile>().SingleOrDefault())
				.WhereNotNull();

			if (waypointOrder.Subject == Self)
			{
				world.Selection.IsQueued = true;

				if (!waypointOrder.IsQueued)
					Waypoints.Clear();

				Waypoints.Add(waypointOrder.Position);

				foreach (var mobile in Followers.Except(mobiles).ToArray())
					mobile.ClearLeader();

				ClearLeader();
			}
			else
				SetLeader(waypointOrder.Subject.Components.OfType<Mobile>().Single());

			PositionNumber = mobiles.ToList().IndexOf(this);
			Stop = false;

			if (Self.CurrentActivity is null)
				Self.QueueActivity(new Move(this, Speed, Acceleration));
		}

		public virtual void HandleOrder(World world, IOrder order)
		{
			switch (order)
			{
				case WaypointOrder waypointOrder:
					HandleOrder(world, waypointOrder);
					break;
			}
		}

		public virtual void OnArrival()
		{
			foreach (var listener in ArrivalEventListeners)
				listener.OnArrival(Self);
		}

		public virtual void UpdateFormation(Mobile leader, int positionNumber) { }
	}

	internal abstract class Mobile<TOptions> : Mobile
		where TOptions : MobileOptions
	{
		public new TOptions Options { get; }

		protected Mobile(Unit self, TOptions options) : base(self, options)
		{
			Options = options;
		}
	}
}
