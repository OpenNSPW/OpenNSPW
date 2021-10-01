using OpenNspw.Components;

namespace OpenNspw.Orders;

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

internal sealed record WaypointOrder(
	Unit Subject,
	Unit[] Selection,
	WPos Position,
	bool IsQueued
) : ISelectionOrder;

internal sealed record TargetOrder(
	Unit Subject,
	Unit[] Selection,
	Unit? Target
) : ISelectionOrder;

internal sealed record LandingCellOrder(
	Unit Subject,
	CPos? LandingCell
) : IUnitOrder;

internal sealed record FlightModeOrder(
	Unit Subject,
	Unit[] Selection,
	FlightMode FlightMode
) : ISelectionOrder;

internal sealed record AirplaneWeaponOrder(
	Unit Subject,
	Unit[] Selection,
	AirplaneWeapon Weapon
) : ISelectionOrder;
