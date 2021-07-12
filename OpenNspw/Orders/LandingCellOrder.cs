namespace OpenNspw.Orders
{
	internal sealed record LandingCellOrder(
		Unit Subject,
		CPos? LandingCell
	) : IUnitOrder;
}
