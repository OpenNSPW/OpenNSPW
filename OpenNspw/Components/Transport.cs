using System.Collections.Generic;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal sealed class TransportOptions : IComponentOptions<Transport>
	{
		public HashSet<short> LandableTerrainTypes { get; init; } = new() { 9, 8, 7, 5, 2 };

		public Transport CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Transport : IComponent<TransportOptions>, IOrderHandler
	{
		public Unit Self { get; }
		public TransportOptions Options { get; }
		public CPos? LandingCell { get; set; }

		public Transport(Unit self, TransportOptions options)
		{
			Self = self;
			Options = options;
		}

		public bool CanLand(CPos value) => Self.World.Map.Contains(value) && Options.LandableTerrainTypes.Contains(Self.World.Map.Tiles[value]);
		public bool CanLand(WPos value) => CanLand(Self.World.Map.CellContaining(value));

		void IOrderHandler.HandleOrder(World world, IOrder order)
		{
			switch (order)
			{
				case LandingCellOrder landingCellOrder:
					LandingCell = landingCellOrder.LandingCell;
					break;
			}
		}
	}
}
