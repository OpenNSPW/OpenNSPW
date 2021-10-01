namespace OpenNspw.Components
{
	internal sealed record FollowerOptions : PausableConditionalComponentOptions<Follower>
	{
		public FollowerOptions()
		{
			RequiresCondition = new("follower");
		}

		public override Follower CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Follower : PausableConditionalComponent<FollowerOptions>, ICreatedEventListener, IUpdatable
	{
		private readonly Lazy<Mobile> _mobile;

		public Follower(Unit self, FollowerOptions options) : base(self, options)
		{
			_mobile = new(() => self.Components.OfType<Mobile>().Single());
		}

		private Mobile Mobile => _mobile.Value;

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_mobile.ForceInitialize();
		}

		void IUpdatable.Update(Unit self)
		{
			if (IsDisabled || IsPaused)
				return;

			if (Mobile.Leader is not Mobile leader)
				return;

			if (!Mobile.Stop)
			{
				if (self.World.WorldTick % 10 == 0)
					Mobile.UpdateFormation(leader, Mobile.PositionNumber);
			}
			else
				Mobile.Waypoints[0] = Mobile.Center;

			if (!WRect.FromCenter(Mobile.Waypoints.First(), new WVec(60, 60)).Contains(Mobile.Center) && !Mobile.Stop)
			{
				Mobile.FormationState = FormationState.Zero;

				if (leader.FormationState == FormationState.Zero)
					leader.FormationState = FormationState.One;

				if (leader.FormationSpeed > Mobile.Options.MaxSpeed || leader.FormationSpeed == 0)
					leader.FormationSpeed = Mobile.Options.MaxSpeed;
			}
			else
			{
				Mobile.FormationState = FormationState.Two;

				if (Mobile.Options.StopOnArrival && leader.Stop)
					Mobile.Stop = true;
			}
		}
	}
}
