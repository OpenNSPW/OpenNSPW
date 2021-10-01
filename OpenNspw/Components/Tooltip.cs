namespace OpenNspw.Components;

internal sealed record TooltipOptions : IComponentOptions<Tooltip>
{
	public string Name { get; init; } = string.Empty;

	public Tooltip CreateComponent(Unit self) => new(self, this);
}

internal sealed class Tooltip : IComponent<TooltipOptions>
{
	public Unit Self { get; }
	public TooltipOptions Options { get; }

	public Tooltip(Unit self, TooltipOptions options)
	{
		Self = self;
		Options = options;
	}
}
