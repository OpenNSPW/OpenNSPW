using OpenNspw.Effects;
using OpenNspw.Projectiles;

namespace OpenNspw.Components;

internal sealed record LandingOperationOptions : PausableConditionalComponentOptions<LandingOperation>
{
	public string? Sound { get; init; }

	public override LandingOperation CreateComponent(Unit self) => new(self, this);
}

internal sealed class LandingOperation : PausableConditionalComponent<LandingOperationOptions>, ICreatedEventListener, IUpdatable
{
	private readonly Lazy<Transport> _transport;

	public LandingOperation(Unit self, LandingOperationOptions options) : base(self, options)
	{
		_transport = new(() => self.GetRequiredComponent<Transport>());
	}

	void ICreatedEventListener.OnCreated(Unit self)
	{
		_transport.ForceInitialize();
	}

	private Transport Transport => _transport.Value;

	private void Attack(Unit self)
	{
		if (Transport.LandingCell is not CPos landingCell)
			return;

		var (length, angle) = (self.World.Map.CenterOfCell(landingCell) - self.Center).ToLengthAndAngle();

		if (!angle.IsWithinTolerance(self.Angle, WAngle.FromDegrees(45)))
			return;

		if (length is < 0 or > 160)
			return;

		Transport.LandingCell = null;

		if (Options.Sound is not null)
			self.World.PlaySound($"SoundEffects/{Options.Sound}", self.Center);

		self.World.Add(new LandingCraft(
			center: self.Center,
			angle: angle,
			speed: 1.0f,
			acceleration: 0,
			ticks: 0,
			duration: 360,
			landingCell: landingCell
		));
	}

	private void Draw(Unit self)
	{
		if (self.Owner.IsAlliedWith(self.World.LocalPlayer))
		{
			self.World.Add(new SpriteEffect(
				layer: EffectLayer.Lower,
				name: "Textures/Effects/effect_44",
				duration: 1,
				mode: SpriteEffectMode.Zero,
				center: self.Center + new WVec(0, -25.0f),
				frame: 0
			));
		}
	}

	void IUpdatable.Update(Unit self)
	{
		if (!self.IsInWorld)
			return;

		if (IsDisabled || IsPaused)
			return;

		Attack(self);

		Draw(self);
	}
}
