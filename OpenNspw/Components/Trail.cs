using OpenNspw.Effects;

namespace OpenNspw.Components;

internal sealed record TrailOptions : IComponentOptions<Trail>
{
	public int Offset { get; init; }

	public Trail CreateComponent(Unit self) => new(self, this);
}

internal sealed class Trail : IComponent<TrailOptions>, ICreatedEventListener, IUpdatable
{
	public Unit Self { get; }
	public TrailOptions Options { get; }

	private readonly Lazy<Mobile> _mobile;

	public Trail(Unit self, TrailOptions options)
	{
		Self = self;
		Options = options;

		_mobile = new(() => self.GetRequiredComponent<Mobile>());
	}

	void ICreatedEventListener.OnCreated(Unit self)
	{
		_mobile.ForceInitialize();
	}

	private Mobile Mobile => _mobile.Value;

	void IUpdatable.Update(Unit self)
	{
		if (self.IsDead)
			return;

		if (self.World.WorldTick % 15 != 0)
			return;

		if (Mobile.Speed < Mobile.Options.MaxSpeed / 3)
			return;

		self.World.Add(new SpriteEffect(
			layer: EffectLayer.Lower,
			name: "Textures/Effects/effect_8",
			duration: self.World.Random.Next(60, 120),
			mode: SpriteEffectMode.Four,
			center: self.Center + (self.Angle + WAngle.FromDegrees(180)).ToVector(Options.Offset),
			frame: 0
		));
	}
}
