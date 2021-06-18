namespace OpenNspw.Components
{
	internal sealed record ArmamentOptions : IComponentOptions<Armament>
	{
		public int MaxAmmo { get; init; }

		public Armament CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Armament : IComponent<ArmamentOptions>
	{
		public Unit Self { get; }
		public ArmamentOptions Options { get; }
		public int Ammo { get; private set; }

		public Armament(Unit self, ArmamentOptions options)
		{
			Self = self;
			Options = options;
			Ammo = options.MaxAmmo;
		}
	}
}
