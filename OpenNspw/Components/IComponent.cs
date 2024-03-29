using Aigamo.Saruhashi;
using OpenNspw.Orders;

namespace OpenNspw.Components;

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
	float Speed { get; }
	bool IsMoving => false;
	IEnumerable<WPos> Waypoints => Enumerable.Repeat(Center, 1);
	IEnumerable<WRect> HitBoxes { get; }
}

internal interface ICreatedEventListener
{
	void OnCreated(Unit self);
}

internal interface IAddedToWorldEventListener
{
	void OnAddedToWorld(Unit self);
}

internal interface IRemovedFromWorldEventListener
{
	void OnRemovedFromWorld(Unit self);
}

internal interface IOrderTargeter
{
	int Priority { get; }

	bool CanTarget(Unit self, Unit? target, WPos position);
}

internal interface IOrderDispatcher
{
	IEnumerable<IOrderTargeter> OrderTargeters { get; }

	IUnitOrder? DispatchOrder(Unit self, IOrderTargeter orderTargeter, Unit? target, WPos position, bool isQueued);
}

internal interface IOrderHandler
{
	void HandleOrder(World world, IUnitOrder unitOrder);
}

internal interface IUpdatable
{
	void Update(Unit self);
}

internal interface IDrawable
{
	void Draw(Unit self, Graphics graphics, Camera camera);
}

// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Traits/TraitsInterfaces.cs#L592
internal delegate void VariableObserverNotifier(Unit self, IReadOnlyDictionary<string, int> variables);

// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Traits/TraitsInterfaces.cs#L593
internal readonly struct VariableObserver
{
	public VariableObserverNotifier Notifier { get; }
	public IEnumerable<string> Variables { get; }

	public VariableObserver(VariableObserverNotifier notifier, IEnumerable<string> variables)
	{
		Notifier = notifier;
		Variables = variables;
	}
}

// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Traits/TraitsInterfaces.cs#L604
internal interface IObservesVariables
{
	IEnumerable<VariableObserver> GetVariableObservers();
}

internal interface IArrivalEventListener
{
	void OnArrival(Unit self);
}
