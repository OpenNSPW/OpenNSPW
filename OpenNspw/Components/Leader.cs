namespace OpenNspw.Components;

internal sealed record LeaderOptions : PausableConditionalComponentOptions<Leader>
{
	public LeaderOptions()
	{
		RequiresCondition = new("leader");
	}

	public override Leader CreateComponent(Unit self) => new(self, this);
}

internal sealed class Leader : PausableConditionalComponent<LeaderOptions>, ICreatedEventListener, IUpdatable
{
	private readonly Lazy<Mobile> _mobile;

	public Leader(Unit self, LeaderOptions options) : base(self, options)
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

		if (!Mobile.IsLeader)
			return;

		if (!Mobile.Stop)
		{
			if (WRect.FromCenter(Mobile.Waypoints.First(), new WVec(80, 80)).Contains(Mobile.Center))
			{
				if (Mobile.Waypoints.Count == 1)
				{
					if (Mobile.Options.StopOnArrival)
						Mobile.Stop = true;

					Mobile.OnArrival();
				}
				else
					Mobile.Waypoints.RemoveAt(0);
			}
		}
		else
			Mobile.Waypoints[0] = Mobile.Center;
	}
}
