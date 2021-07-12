namespace OpenNspw.Orders
{
	internal sealed record WaypointOrder(
		Unit Subject,
		Unit[] Selection,
		WPos Position,
		bool IsQueued
	) : ISelectionOrder;
}
