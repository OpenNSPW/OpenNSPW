namespace OpenNspw.Orders
{
	internal sealed record LandingCellOrder(
		int SubjectId,
		CPos? LandingCell
	) : IUnitOrder;
}
