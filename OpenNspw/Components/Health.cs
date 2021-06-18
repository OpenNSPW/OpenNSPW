namespace OpenNspw.Components
{
	internal sealed record HealthOptions : IComponentOptions<Health>
	{
		public int MaxHP { get; init; }

		public Health CreateComponent(Unit self) => new(self, this);
	}

	internal enum DamageState
	{
		Undamaged,
		Light,
		Medium,
		Heavy,
		Critical,
		Dead,
	}

	internal sealed class Health : IComponent<HealthOptions>
	{
		public Unit Self { get; }
		public HealthOptions Options { get; }
		public int HP { get; private set; }

		public Health(Unit self, HealthOptions options)
		{
			Self = self;
			Options = options;
			HP = options.MaxHP;
		}

		public DamageState DamageState
		{
			get
			{
				if (HP <= 0)
					return DamageState.Dead;

				if (HP <= Options.MaxHP * 0.2f)
					return DamageState.Critical;

				if (HP <= Options.MaxHP * 0.5f)
					return DamageState.Heavy;

				if (HP <= Options.MaxHP * 0.7f)
					return DamageState.Medium;

				if (HP == Options.MaxHP)
					return DamageState.Undamaged;

				return DamageState.Light;
			}
		}
	}
}
