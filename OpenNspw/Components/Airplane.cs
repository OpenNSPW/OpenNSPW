using System.Diagnostics.CodeAnalysis;
using OpenNspw.Activities;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal sealed record AirplaneOptions : MobileOptions
	{
		public override Airplane CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Airplane : Mobile, IOrderHandler
	{
		public override AirplaneOptions Options { get; }
		public Hangar? Hangar { get; set; }

		public Airplane(Unit self, AirplaneOptions options) : base(self, options)
		{
			Options = options;
		}

		public override bool IsMoving => base.IsMoving || Self.CurrentActivity is TakeOff or Land;

		[MemberNotNullWhen(true, nameof(Hangar))]
		public bool IsInHangar => !Self.World.Units.Contains(Self)/* TODO: cache */;

		public bool CanTakeOff => Hangar?.AllowTakeoff ?? false;
		public bool CanLand => Hangar?.AllowLanding ?? false;

		public override void HandleOrder(World world, IOrder order)
		{
			base.HandleOrder(world, order);

			switch (order)
			{
				case WaypointOrder:
					if (IsInHangar)
						Self.CurrentActivity = new TakeOff(Self);
					break;
			}
		}

		public void Fold()
		{
			if (Self.World.Assets.Textures.TryGetValue($"Textures/Units/{Self.Name}_folded", out var texture))
				Self.Texture = texture;
		}

		public void Unfold()
		{
			Self.Texture = Self.World.Assets.Textures[$"Textures/Units/{Self.Name}"];
		}
	}
}
