namespace OpenNspw.Orders
{
	internal interface IOrder
	{
	}

	internal interface IUnitOrder : IOrder
	{
		Unit Subject { get; }
	}

	internal interface ISelectionOrder : IUnitOrder
	{
		Unit[] Selection { get; }
	}
}
