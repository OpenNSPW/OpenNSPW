using OpenNspw.Components;

namespace OpenNspw.Activities
{
	internal abstract class MoveBase : Activity, IMove
	{
		private readonly Mobile _mobile;
		private readonly bool _keepFormation;

		public float Speed { get; private set; }
		public float Acceleration { get; private set; }

		public MoveBase(Mobile mobile, bool keepFormation, float speed, float acceleration)
		{
			_mobile = mobile;
			_keepFormation = keepFormation;

			Speed = speed;
			Acceleration = acceleration;
		}

		public abstract WPos Destination { get; }

		public abstract bool IsMoving { get; }

		protected virtual void OnMoving(bool canMove) { }

		protected override bool UpdateCore(Unit self)
		{
			if (IsCanceling)
				return true;

			if (IsMoving)
			{
				var desiredAngle = WAngle.FromVector(Destination - _mobile.Center);
				var canMove = _mobile.CanMove(_mobile.Center + desiredAngle.ToVector(80));

				_mobile.TurnSpeed = _mobile.GetTurnSpeed(desiredAngle - _mobile.Angle);
				_mobile.Angle += _mobile.TurnSpeed;

				Acceleration = canMove
					? _mobile.GetAcceleration(_keepFormation, desiredAngle)
					: -_mobile.Options.Acceleration;

				if (canMove && _mobile.Angle.IsWithinTolerance(desiredAngle, angleTolerance: WAngle.FromDegrees(22.5f)))
				{
					if (_keepFormation)
					{
						switch (_mobile.FormationState)
						{
							case FormationState.One:
								_mobile.FormationSpeed = 0;
								break;

							case FormationState.Two when _mobile.Options.MaxSpeed >= _mobile.Leader?.Options.MaxSpeed:
								Speed = _mobile.Leader.Speed;
								break;
						}
					}

					_mobile.FormationState = FormationState.Zero;
				}

				OnMoving(canMove);
			}
			else
				Acceleration = -_mobile.Options.Acceleration * 2;

			Speed = Math.Max(_mobile.GetSpeed(Acceleration), IsMoving ? _mobile.Options.MinSpeed : 0);
			_mobile.Center += _mobile.Angle.ToVector(Speed);

			if (!IsMoving && !_mobile.Stop)
			{
				Queue(new Move(_mobile, Speed, Acceleration));
				return true;
			}

			if (IsMoving)
				return false;

			if (Speed > 0)
				return false;

			return true;
		}
	}
}
