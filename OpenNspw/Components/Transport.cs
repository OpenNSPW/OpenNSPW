using OpenNspw.Orders;

namespace OpenNspw.Components;

internal sealed class TransportOptions : IComponentOptions<Transport>
{
	public HashSet<short> LandableTerrainTypes { get; init; } = new() { 9, 8, 7, 5, 2 };

	public Transport CreateComponent(Unit self) => new(self, this);
}

internal sealed class Transport : IComponent<TransportOptions>, IOrderDispatcher, IOrderHandler
{
	private sealed class LandingCellOrderTargeter : IOrderTargeter
	{
		private readonly Transport _transport;

		public LandingCellOrderTargeter(Transport transport)
		{
			_transport = transport;
		}

		public int Priority => 3;

		public bool CanTarget(Unit self, Unit? target, WPos position)
		{
			if (target is not null)
				return false;

			return _transport.CanLand(position) && WRect.FromCenter(self.World.Map.CenterOfCell(position), new WVec(40, 40)).Contains(position);
		}
	}

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

	IEnumerable<IOrderTargeter> IOrderDispatcher.OrderTargeters
	{
		get
		{
			yield return new LandingCellOrderTargeter(this);
		}
	}

	IUnitOrder? IOrderDispatcher.DispatchOrder(Unit self, IOrderTargeter orderTargeter, Unit? target, WPos position, bool isQueued)
	{
		if (orderTargeter is LandingCellOrderTargeter)
		{
			var newLandingCell = self.World.Map.CellContaining(position);
			var canceled = LandingCell == newLandingCell;

			return new LandingCellOrder(
				Subject: self,
				LandingCell: canceled ? null : newLandingCell
			);
		}

		return null;
	}

	void IOrderHandler.HandleOrder(World world, IUnitOrder unitOrder)
	{
		switch (unitOrder)
		{
			case LandingCellOrder landingCellOrder:
				LandingCell = landingCellOrder.LandingCell;
				break;
		}
	}
}
