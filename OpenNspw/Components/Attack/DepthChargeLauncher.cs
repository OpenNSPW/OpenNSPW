using OpenNspw.Projectiles;

namespace OpenNspw.Components;

internal enum DepthChargeLauncherType
{
	Normal,
	Random,
}

internal sealed record DepthChargeLauncherOptions : PausableConditionalComponentOptions<DepthChargeLauncher>
{
	public int Interval { get; init; }
	public DepthChargeLauncherType LauncherType { get; init; }

	public override DepthChargeLauncher CreateComponent(Unit self) => new(self, this);
}

internal sealed class DepthChargeLauncher : PausableConditionalComponent<DepthChargeLauncherOptions>, ICreatedEventListener, IUpdatable
{
	private readonly Lazy<Mobile> _mobile;

	public DepthChargeLauncher(Unit self, DepthChargeLauncherOptions options) : base(self, options)
	{
		_mobile = new(() => self.GetRequiredComponent<Mobile>());
	}

	public Mobile Mobile => _mobile.Value;

	void ICreatedEventListener.OnCreated(Unit self)
	{
		_mobile.ForceInitialize();
	}

	void IUpdatable.Update(Unit self)
	{
		if (!self.IsInWorld)
			return;

		if (IsDisabled || IsPaused)
			return;

		if (self.World.WorldTick % (Options.Interval/* TODO: * damageFactor */) != 0)
			return;

		if (Mobile.Speed < Mobile.Options.MaxSpeed)
			return;

		static bool CanAttack(Unit self, Unit other)
		{
			if (other.Owner == self.Owner)
				return false;

			if (other.GetComponent<Submarine>() is not Submarine submarine)
				return false;

			if (!submarine.Submerged)
				return false;

			if (!other.CanBeViewedBy(self.Owner))
				return false;

			if (submarine.Bounds.Contains(self.Center))
				return true;

			return false;
		}

		var target = self.World.Units.FirstOrDefault(u => CanAttack(self, u));

		if (target is null)
			return;

		// TODO

		self.World.PlaySound("SoundEffects/spl1", self.Center);

		var center = Options.LauncherType switch
		{
			DepthChargeLauncherType.Normal => self.Center + (self.Angle + WAngle.FromDegrees(180)).ToVector(20),
			DepthChargeLauncherType.Random => self.Center + (self.Angle + WAngle.FromDegrees(120 + self.World.Random.Next(3) * 60)).ToVector(35),
			_ => throw new InvalidOperationException(),
		};

		self.World.Add(new DepthCharge(center: center, duration: 100));
	}
}
