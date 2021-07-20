using System.Linq;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal sealed record ArmamentOptions : IComponentOptions<Armament>
	{
		public int MaxAmmo { get; init; }

		public Armament CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Armament : IComponent<ArmamentOptions>, IOrderHandler
	{
		public Unit Self { get; }
		public ArmamentOptions Options { get; }
		public int Ammo { get; private set; }
		public Unit? Target { get; private set; }

		public Armament(Unit self, ArmamentOptions options)
		{
			Self = self;
			Options = options;
			Ammo = options.MaxAmmo;
		}

		private void HandleOrder(World world, TargetOrder targetOrder)
		{
			var target = targetOrder.TargetId is int targetId ? world.AllUnits[targetId] : null;

			if (target?.Owner == Self.Owner)
				return;

			var armaments = targetOrder.ToSelection(world)
				.Select(u => u.GetComponent<Armament>())
				.WhereNotNull();

			foreach (var armament in armaments)
				armament.Target = target;
		}

		void IOrderHandler.HandleOrder(World world, IOrder order)
		{
			switch (order)
			{
				case TargetOrder targetOrder:
					HandleOrder(world, targetOrder);
					break;
			}
		}
	}
}
