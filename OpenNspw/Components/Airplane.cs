using System.Diagnostics.CodeAnalysis;

namespace OpenNspw.Components
{
	internal sealed record AirplaneOptions : IComponentOptions<Airplane>
	{
		public Airplane CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Airplane : IComponent<AirplaneOptions>, IUnit
	{
		public Unit Self { get; }
		public AirplaneOptions Options { get; }
		public WPos Center { get; set; }
		public WAngle Angle { get; set; }
		public Hangar? Hangar { get; set; }

		public Airplane(Unit self, AirplaneOptions options)
		{
			Self = self;
			Options = options;
		}

		[MemberNotNullWhen(true, nameof(Hangar))]
		public bool IsInHangar => !Self.World.Units.Contains(Self)/* TODO: cache */;
	}
}
