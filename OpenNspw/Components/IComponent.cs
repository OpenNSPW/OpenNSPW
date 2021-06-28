using System.Collections.Generic;
using System.Linq;
using OpenNspw.Orders;

namespace OpenNspw.Components
{
	internal interface IComponentOptions
	{
		IComponent CreateComponent(Unit self);
	}

	internal interface IComponentOptions<TComponent> : IComponentOptions
		where TComponent : IComponent
	{
		new TComponent CreateComponent(Unit self);

		IComponent IComponentOptions.CreateComponent(Unit self) => CreateComponent(self);
	}

	internal interface IComponent
	{
		Unit Self { get; }
		IComponentOptions Options { get; }
	}

	internal interface IComponent<TOptions> : IComponent
		where TOptions : IComponentOptions
	{
		new TOptions Options { get; }

		IComponentOptions IComponent.Options => Options;
	}

	internal interface IUnit
	{
		Unit Self { get; }
		WPos Center { get; set; }
		WAngle Angle { get; set; }
		bool IsMoving => false;
		IEnumerable<WPos> Waypoints => Enumerable.Repeat(Center, 1);
	}

	internal interface ICreatedEventListener
	{
		void OnCreated(Unit self);
	}

	internal interface IOrderHandler
	{
		void HandleOrder(World world, IOrder order);
	}

	internal interface IUpdatable
	{
		void Update(Unit self);
	}
}
