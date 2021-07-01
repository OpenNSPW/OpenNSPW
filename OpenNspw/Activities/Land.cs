using System;
using OpenNspw.Components;

namespace OpenNspw.Activities
{
	internal sealed class Land : Activity
	{
		public enum LandState
		{
			Approach,
			Landing,
			TaxiIn,
		}

		private readonly Airplane _airplane;
		private readonly Hangar _hangar;

		public LandState State { get; private set; }
		public float Speed { get; private set; } = 5.0f;

		public Land(Unit self)
		{
			_airplane = self.GetRequiredComponent<Airplane>();
			_hangar = _airplane.Hangar ?? throw new InvalidOperationException();
		}

		protected override void OnFirstUpdate(Unit self)
		{
			_airplane.Center = new WPos(117/* TODO: const */ / 2 + self.World.Random.Next(-7, 9), 436/* TODO: const */ + 40);
			_airplane.Angle = CardinalDirection.North;
		}

		protected override Activity? UpdateCore(Unit self)
		{
			var centerY = (int)_airplane.Center.Y;

			switch (State)
			{
				case LandState.Approach when centerY <= 436/* TODO: const */ - 150:
					State = LandState.Landing;

					Speed = 1.5f;
					break;

				case LandState.Landing when centerY <= 436/* TODO: const */ - 200:
					State = LandState.TaxiIn;

					Speed /= 2;

					_airplane.Fold();
					break;

				case LandState.TaxiIn when centerY <= 436/* TODO: const */ - 270:
					// TODO

					_hangar.Park(_airplane);

					// TODO

					return NextActivity;
			}

			_airplane.Center += _airplane.Angle.ToVector(Speed).FlipY();

			return this;
		}
	}
}
