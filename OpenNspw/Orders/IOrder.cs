using System.Collections.Generic;
using System.Linq;

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

	internal static class SelectionOrderExtensions
	{
		public static IEnumerable<Unit> ToSelection(this ISelectionOrder selectionOrder, World world) => selectionOrder.SelectionIds.Select(i => world.AllUnits[i]);
	}
}
