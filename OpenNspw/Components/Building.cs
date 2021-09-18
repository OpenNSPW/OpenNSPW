namespace OpenNspw.Components
{
	internal sealed record BuildingOptions : IComponentOptions<Building>
	{
		public Building CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Building : IComponent<BuildingOptions>, IUnit
	{
		public Unit Self { get; }
		public BuildingOptions Options { get; }
		public WPos Center { get; set; }
		public WAngle Angle { get; set; }
		public float Speed => 0;

		public Building(Unit self, BuildingOptions options)
		{
			Self = self;
			Options = options;
		}
	}
}
