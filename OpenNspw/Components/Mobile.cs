using System.Collections.Generic;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal record MobileOptions : IComponentOptions<Mobile>
	{
		public virtual Mobile CreateComponent(Unit self) => new(self, this);
	}

	internal class Mobile : IComponent<MobileOptions>, IUnit, ICreatedEventListener, IOrderHandler
	{
		public Unit Self { get; }
		public virtual MobileOptions Options { get; }
		public WPos Center { get; set; }
		public WAngle Angle { get; set; }
		public bool IsMoving { get; set; } = true;
		public List<WPos> Waypoints { get; } = new();

		public Mobile(Unit self, MobileOptions options)
		{
			Self = self;
			Options = options;
		}

		bool IUnit.IsMoving => IsMoving;
		IEnumerable<WPos> IUnit.Waypoints => Waypoints;

		void ICreatedEventListener.OnCreated(Unit self)
		{
			Waypoints.Add(Center);
		}

		private void HandleOrder(World world, WaypointOrder waypointOrder)
		{
			world.Selection.IsQueued = true;

			if (!waypointOrder.IsQueued)
				Waypoints.Clear();

			Waypoints.Add(waypointOrder.Position);

			IsMoving = true;
		}

		void IOrderHandler.HandleOrder(World world, IOrder order)
		{
			switch (order)
			{
				case WaypointOrder waypointOrder:
					HandleOrder(world, waypointOrder);
					break;
			}
		}
	}
}
