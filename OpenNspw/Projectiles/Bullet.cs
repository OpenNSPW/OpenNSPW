using Microsoft.Xna.Framework;
using OpenNspw.Effects;

namespace OpenNspw.Projectiles;

internal sealed class Bullet : IProjectile
{
	public Unit? Target { get; }
	public WPos Position { get; private set; }
	public WAngle Angle { get; }
	public float Speed { get; private set; }
	public float Acceleration { get; }
	public float TerminalSpeed { get; }

	public Bullet(Unit? target, WPos position, WAngle angle, float speed, float acceleration, float terminalSpeed)
	{
		Target = target;
		Position = position;
		Angle = angle;
		Speed = speed;
		Acceleration = acceleration;
		TerminalSpeed = terminalSpeed;
	}

	private float PreviousSpeed => Speed - Acceleration;
	private WPos PreviousPosition => Position - Angle.ToVector(PreviousSpeed);

	public void Update(World world)
	{
		if (Speed < TerminalSpeed)
		{
			world.AddFrameEndAction(w => w.Remove(this));
			return;
		}

		Position += Angle.ToVector(Speed);
		Speed += Acceleration;

		if (Target is not null && WRect.FromCenter(Target.Center, new WVec(20, 20)).Contains(Position))
		{
			world.AddFrameEndAction(w => w.Remove(this));

			// TODO

			world.Add(new SpriteEffect(
				layer: EffectLayer.Upper,
				name: "Textures/Effects/effect_1",
				duration: 20,
				mode: SpriteEffectMode.One,
				center: Position,
				frame: 0
			));
		}
		else
		{
			world.Add(new LineEffect(
				layer: EffectLayer.Upper,
				duration: 1,
				point1: Position,
				point2: PreviousPosition,
				color: Color.White
			));
		}
	}
}
