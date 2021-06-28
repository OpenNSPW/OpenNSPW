using System.Diagnostics.CodeAnalysis;

namespace OpenNspw.Components
{
	internal sealed record AirplaneOptions : MobileOptions
	{
		public override Airplane CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Airplane : Mobile
	{
		public override AirplaneOptions Options { get; }
		public Hangar? Hangar { get; set; }

		public Airplane(Unit self, AirplaneOptions options) : base(self, options)
		{
			Options = options;
		}

		[MemberNotNullWhen(true, nameof(Hangar))]
		public bool IsInHangar => !Self.World.Units.Contains(Self)/* TODO: cache */;
	}
}
