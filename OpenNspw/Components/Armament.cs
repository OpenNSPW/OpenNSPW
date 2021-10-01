using OpenNspw.Orders;

namespace OpenNspw.Components;

internal sealed record ArmamentOptions : ConditionalComponentOptions<Armament>
{
	public int MaxAmmo { get; init; }

	public override Armament CreateComponent(Unit self) => new(self, this);
}

internal sealed class Armament : ConditionalComponent<ArmamentOptions>, IOrderDispatcher, IOrderHandler
{
	private sealed class TargetOrderTargeter : IOrderTargeter
	{
		public int Priority => 2;

		public bool CanTarget(Unit self, Unit? target, WPos position)
		{
			if (target is null || target.Owner == self.Owner)
				return false;

			return true;
		}
	}

	public int Ammo { get; private set; }
	public Unit? Target { get; private set; }

	public Armament(Unit self, ArmamentOptions options) : base(self, options)
	{
		Ammo = options.MaxAmmo;
	}

	IEnumerable<IOrderTargeter> IOrderDispatcher.OrderTargeters
	{
		get
		{
			if (IsDisabled)
				yield break;

			yield return new TargetOrderTargeter();
		}
	}

	IUnitOrder? IOrderDispatcher.DispatchOrder(Unit self, IOrderTargeter orderTargeter, Unit? target, WPos position, bool isQueued)
	{
		if (orderTargeter is TargetOrderTargeter)
		{
			var canceled = Target == target;

			return new TargetOrder(
				Subject: self,
				Selection: self.World.Selection.Units.ToArray(),
				Target: canceled ? null : target
			);
		}

		return null;
	}

	private void HandleOrder(World world, TargetOrder targetOrder)
	{
		var target = targetOrder.Target;

		if (target?.Owner == Self.Owner)
			return;

		var armaments = targetOrder.Selection
			.Select(u => u.GetComponent<Armament>())
			.WhereNotNull();

		foreach (var armament in armaments)
			armament.Target = target;
	}

	void IOrderHandler.HandleOrder(World world, IUnitOrder unitOrder)
	{
		switch (unitOrder)
		{
			case TargetOrder targetOrder:
				HandleOrder(world, targetOrder);
				break;
		}
	}

	public void ClearTarget(bool clearAmmo)
	{
		Target = null;

		if (clearAmmo)
			Ammo = 0;
	}
}
