namespace OpenNspw.Orders
{

	internal sealed record WaypointOrder(
		int SubjectId,
		int[] SelectionIds,
		WPos Position,
		bool IsQueued
	) : ISelectionOrder;
}
