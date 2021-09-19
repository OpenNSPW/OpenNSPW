using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenNspw.Components
{
	internal sealed record SubmarineOptions : IComponentOptions<Submarine>
	{
		public Submarine CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Submarine : IComponent<SubmarineOptions>, ICreatedEventListener, IHitBoxes
	{
		public Unit Self { get; }
		public SubmarineOptions Options { get; }

		public bool Submerged { get; private set; }

		private readonly Lazy<Ship> _ship;

		public Submarine(Unit self, SubmarineOptions options)
		{
			Self = self;
			Options = options;

			_ship = new(() => self.GetRequiredComponent<Ship>());
		}

		private Ship Ship => _ship.Value;

		IEnumerable<WRect> IHitBoxes.HitBoxes => Submerged
			? Enumerable.Repeat(WRect.FromCenter(Self.Center, new WVec(100, 100)), 1)
			: (Ship as IHitBoxes).HitBoxes;

		void ICreatedEventListener.OnCreated(Unit self)
		{
			_ship.ForceInitialize();
		}
	}
}
