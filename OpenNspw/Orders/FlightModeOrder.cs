using OpenNspw.Components;

namespace OpenNspw.Orders
{
	internal sealed record FlightModeOrder(
		Unit Subject,
		Unit[] Selection,
		FlightMode FlightMode
	) : ISelectionOrder;
}
