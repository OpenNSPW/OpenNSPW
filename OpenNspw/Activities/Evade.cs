using OpenNspw.Components;

namespace OpenNspw.Activities
{
	internal sealed class Evade : MoveBase
	{
		private readonly Mobile _mobile;

		public override WPos Destination { get; }
		public int RemainingTicks { get; private set; }

		public Evade(Mobile mobile, float speed, float acceleration, WPos destination, int duration)
			: base(mobile, keepFormation: false, speed, acceleration)
		{
			_mobile = mobile;

			Destination = destination;
			RemainingTicks = duration;
		}

		public override bool IsMoving => RemainingTicks != 0;

		protected override void OnMoving(bool canMove)
		{
			RemainingTicks--;

			if (!canMove || WRect.FromCenter(Destination, new WVec(80, 80)).Contains(_mobile.Center))
				RemainingTicks = 0;
		}
	}
}
