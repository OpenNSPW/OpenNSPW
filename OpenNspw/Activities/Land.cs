using OpenNspw.Components;

namespace OpenNspw.Activities
{
	public enum LandState
	{
		Approach,
		Landing,
		TaxiIn,
	}

	internal sealed class Land : Activity
	{
		private readonly Airplane _airplane;
		private readonly Hangar _hangar;

		public LandState LandState { get; private set; }
		public float Speed { get; private set; } = 5.0f;

		public Land(Airplane airplane, Hangar hangar)
		{
			_airplane = airplane;
			_hangar = hangar;
		}

		protected override void OnFirstRun(Unit self)
		{
			var selection = self.World.Selection;

			if (selection.Units.FirstOrDefault() == self)
			{
				selection.Clear();
				selection.MouseFocusUnit = _hangar.Self;
			}

			if (selection.MouseFocusUnit == self)
				selection.MouseFocusUnit = _hangar.Self;

			if (selection.Units.Contains(self))
				selection.Units.Remove(self);

			_hangar.Add(_airplane);

			_airplane.Center = new WPos(117/* TODO: const */ / 2 + self.World.Random.Next(-7, 9), 436/* TODO: const */ + 40);
			_airplane.Angle = CardinalDirection.North;
		}

		protected override bool UpdateCore(Unit self)
		{
			var centerY = (int)_airplane.Center.Y;

			switch (LandState)
			{
				case LandState.Approach when centerY <= 436/* TODO: const */ - 150:
					LandState = LandState.Landing;

					Speed = 1.5f;
					break;

				case LandState.Landing when centerY <= 436/* TODO: const */ - 200:
					LandState = LandState.TaxiIn;

					Speed /= 2;

					_airplane.Fold();
					break;

				case LandState.TaxiIn when centerY <= 436/* TODO: const */ - 270:
					_airplane.FlightMode = FlightMode.Cruise;
					_hangar.Park(_airplane);
					_airplane.Stop = true;

					_airplane.Weapon = AirplaneWeapon.Nothing;
					// TODO

					return true;
			}

			_airplane.Center += _airplane.Angle.ToVector(Speed).FlipY();

			return false;
		}
	}
}
