namespace OpenNspw.Components
{
	internal sealed record ShipOptions : MobileOptions
	{
		public override Ship CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Ship : Mobile
	{
		public override ShipOptions Options { get; }

		public Ship(Unit self, ShipOptions options) : base(self, options)
		{
			Options = options;
		}
	}
}
