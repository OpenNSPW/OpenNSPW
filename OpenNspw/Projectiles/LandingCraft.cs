using OpenNspw.Components;
using OpenNspw.Effects;

namespace OpenNspw.Projectiles;

internal sealed class LandingCraft : IProjectile
{
	public string? Unit { get; }
	public int Ticks { get; private set; }
	public int Duration { get; }
	public CPos LandingCell { get; }
	public Player Owner { get; }
	public WPos Center { get; private set; }
	public WAngle Angle { get; }
	public float Speed { get; private set; }
	public float Acceleration { get; }

	public LandingCraft(string? unit, WPos center, WAngle angle, float speed, float acceleration, int ticks, int duration, CPos landingCell, Player owner)
	{
		Unit = unit;
		Center = center;
		Angle = angle;
		Speed = speed;
		Acceleration = acceleration;
		Ticks = ticks;
		Duration = duration;
		LandingCell = landingCell;
		Owner = owner;
	}

	private float PreviousSpeed => Speed - Acceleration;

	private WPos PreviousCenter => Center - Angle.ToVector(PreviousSpeed);

	public void Update(World world)
	{
		if (Ticks > Duration)
		{
			world.AddFrameEndAction(w => w.Remove(this));
			return;
		}

		Center += Angle.ToVector(Speed);
		Speed += Acceleration;

		if (WRect.FromCenter(world.Map.CenterOfCell(LandingCell), new WVec(40, 40)).Contains(Center))
		{
			if (Unit is not null)
			{
				if (!world.Units.Any(u => !u.IsDead && u.HasComponent<Building>() && WRect.FromCenter(u.Center, new WVec(40, 40)).Contains(Center)))
				{
					world.Units.Add(world.CreateUnit(
						name: Unit,
						owner: Owner,
						center: world.Map.CenterOfCell(LandingCell),
						angle: WAngle.Zero
					));
				}
			}

			world.AddFrameEndAction(w => w.Remove(this));
		}
		else
		{
			Ticks++;

			if (Ticks == 1)
			{
				world.Add(new SpriteEffect(
					layer: EffectLayer.Lower,
					name: "Textures/Effects/effect_8",
					duration: 30,
					mode: SpriteEffectMode.Zero,
					center: Center,
					frame: 0
				));
			}

			if (Ticks >= 0)
			{
				if (!world.Map.IsGroundTile(Center))
				{
					if (world.WorldTick % 5 == 0)
					{
						world.Add(new SpriteEffect(
							layer: EffectLayer.Lower,
							name: "Textures/Effects/effect_8",
							duration: world.LocalRandom.Next(30, 55),
							mode: SpriteEffectMode.Four,
							center: PreviousCenter,
							frame: 0
						));
					}
				}

				world.Add(new SpriteEffect(
					layer: EffectLayer.Lower,
					name: "Textures/Effects/effect_36",
					duration: 1,
					mode: SpriteEffectMode.Zero,
					center: Center,
					frame: Angle.Quantize()
				));
			}
		}
	}
}
