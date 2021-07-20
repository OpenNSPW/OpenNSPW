namespace OpenNspw.Orders
{
	internal sealed record TargetOrder(
		int SubjectId,
		int[] SelectionIds,
		int? TargetId
	) : ISelectionOrder;
}
