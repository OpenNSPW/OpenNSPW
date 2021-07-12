namespace OpenNspw.Orders
{
	internal sealed record TargetOrder(
		Unit Subject,
		Unit[] Selection,
		Unit? Target
	) : ISelectionOrder;
}
