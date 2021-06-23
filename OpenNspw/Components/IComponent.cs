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
		WPos Center { get; set; }
		WAngle Angle { get; set; }
	}

	internal interface ICreatedEventListener
	{
		void OnCreated(Unit self);
	}
}
