using System;
using OpenNspw.Components;

namespace OpenNspw.Activities
{
	internal sealed class TakeOff : Activity
	{
		public enum TakeOffState
		{
			PushBack1,
			PushBack2,
			TaxiOut,
			Takeoff,
		}

		private readonly Airplane _airplane;
		private readonly Hangar _hangar;

		public TakeOffState State { get; private set; }
		public int Count/* TODO: rename */ { get; private set; }

		public TakeOff(Unit self)
		{
			_airplane = self.GetRequiredComponent<Airplane>();
			_hangar = _airplane.Hangar ?? throw new InvalidOperationException();
		}

		protected override Activity? UpdateCore(Unit self)
		{
			var (centerX, centerY) = ((int)_airplane.Center.X, (int)_airplane.Center.Y);

			switch (State)
			{
				case TakeOffState.PushBack1 when centerX == 117/* TODO: const */ / 2:
					State = TakeOffState.PushBack2;

					_airplane.Angle = CardinalDirection.South;
					break;

				case TakeOffState.PushBack2 when centerY >= 370:
					State = TakeOffState.TaxiOut;

					_airplane.Angle = CardinalDirection.North;
					_airplane.Center += (++_hangar.TakeOffCount % 2 != 0) ? new WVec(15, 0) : new WVec(-15, 0);
					break;

				case TakeOffState.TaxiOut when centerY == 370 - 80:
					State = TakeOffState.Takeoff;

					_airplane.Unfold();
					break;

				case TakeOffState.Takeoff when centerY <= 370 - 120:
					Count++;

					if (Count == 40 /* TODO: check if the owner is the local player */ && self.World.Selection.MouseFocusUnit == _hangar.Self)
						Sound.Default.Play("SoundEffects/take_off");

					_airplane.Center += _airplane.Angle.ToVector(Count / 20).FlipY();

					if (centerY <= -30)
					{
						_airplane.Center = _hangar.Self.Center;
						// TODO
						_airplane.Angle = WAngle.FromFacing(_hangar.Self.Angle.Facing);

						_hangar.Remove(_airplane);

						return NextActivity;
					}
					break;
			}

			_airplane.Center += _airplane.Angle.ToVector(0.8f).FlipY();

			return this;
		}
	}
}
