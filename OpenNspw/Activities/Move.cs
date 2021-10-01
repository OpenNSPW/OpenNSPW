using OpenNspw.Components;

namespace OpenNspw.Activities;

internal sealed class Move : MoveBase
{
	private readonly Mobile _mobile;

	public Move(Mobile mobile, float speed, float acceleration)
		: base(mobile, keepFormation: true, speed, acceleration)
	{
		_mobile = mobile;
	}

	public override WPos Destination => _mobile.Waypoints.First();

	public override bool IsMoving => !_mobile.Stop;
}
