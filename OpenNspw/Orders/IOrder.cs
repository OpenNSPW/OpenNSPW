namespace OpenNspw.Orders
{
	internal interface IOrder
	{
	}

	internal interface IUnitOrder : IOrder
	{
		int SubjectId { get; }
	}

	internal interface ISelectionOrder : IUnitOrder
	{
		int[] SelectionIds { get; }
	}
}
