namespace OpenNspw.Components
{
	internal sealed record ShipOptions : IComponentOptions<Ship>
	{
		public Ship CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Ship : IComponent<ShipOptions>, IUnit
	{
		public Unit Self { get; }
		public ShipOptions Options { get; }
		public WPos Center { get; set; }
		public WAngle Angle { get; set; }

		public Ship(Unit self, ShipOptions options)
		{
			Self = self;
			Options = options;
		}
	}
}
