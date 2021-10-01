namespace OpenNspw.Components;

internal sealed record SubmarineOptions : IComponentOptions<Submarine>
{
	public Submarine CreateComponent(Unit self) => new(self, this);
}

internal sealed class Submarine : IComponent<SubmarineOptions>, ICreatedEventListener
{
	public Unit Self { get; }
	public SubmarineOptions Options { get; }

	public bool Submerged { get; private set; }

	private readonly Lazy<Ship> _ship;

	public Submarine(Unit self, SubmarineOptions options)
	{
		Self = self;
		Options = options;

		_ship = new(() => self.GetRequiredComponent<Ship>());
	}

	private Ship Ship => _ship.Value;

	public IEnumerable<WRect> HitBoxes => Submerged
		? Enumerable.Repeat(WRect.FromCenter(Self.Center, new WVec(100, 100)), 1)
		: Ship.HitBoxes;

	void ICreatedEventListener.OnCreated(Unit self)
	{
		_ship.ForceInitialize();
	}
}
