using System.Collections.Generic;
using System.Linq;
using Aigamo.Saruhashi;
using Aigamo.Saruhashi.MonoGame;
using MonoGame.Extended;
using DColor = System.Drawing.Color;
using DPen = System.Drawing.Pen;

namespace OpenNspw.Components
{
	internal sealed record ShipOptions : MobileOptions<Ship>
	{
		public int HitBoxSize { get; init; }

		public ShipOptions()
		{
			TerrainTypes = new HashSet<short> { 0 };
			StopOnArrival = true;
		}

		public override Ship CreateComponent(Unit self) => new(self, this);
	}

	internal sealed class Ship : Mobile<ShipOptions>, IDrawable
	{
		public WAngle AngleToLeader { get; set; }
		public float DistanceToLeader { get; set; }

		public Ship(Unit self, ShipOptions options) : base(self, options) { }

		public override bool CanFollow(Mobile leader)
		{
			if (leader is not Ship)
				return false;

			return base.CanFollow(leader);
		}

		public override bool CanMove(WPos position)
		{
			if (true/* TODO */)
			{
				var ships = Self.World.Units
					.Where(u => !u.IsDead && u != Self /* TODO */)
					.Select(u => u.GetComponent<Ship>())
					.WhereNotNull();

				if (ships.Any(s => WRect.FromCenter(s.Center, new WVec(80, 80)).Contains(Center + Angle.ToVector(40 + Options.MaxSpeed * 10))))
					return false;
			}

			return base.CanMove(position);
		}

		protected override float GetAcceleration(WAngle desiredAngle)
		{
			var acceleration = Options.Acceleration;

			if (Angle.IsWithinTolerance(desiredAngle, angleTolerance: WAngle.FromDegrees(45.0f)))
				return (Speed > GetMaxSpeed() / 3 * 2) ? -acceleration : acceleration;

			if (Angle.IsWithinTolerance(desiredAngle, angleTolerance: WAngle.FromDegrees(80.0f)))
				return (Speed > GetMaxSpeed() / 2) ? -acceleration : acceleration;

			return (Speed > Options.MinSpeed) ? -acceleration : acceleration;
		}

		public override void ClearLeader()
		{
			base.ClearLeader();

			AngleToLeader = WAngle.Zero;
			DistanceToLeader = 0;
		}

		public override void UpdateFormation(Mobile leader, int positionNumber)
		{
			Waypoints.Clear();
			Waypoints.Add(leader.Center + (AngleToLeader + leader.Angle).ToVector(DistanceToLeader));

			// TODO
		}

		private void DetermineAngleAndDistanceToLeader(Mobile leader)
		{
			var (length, angle) = (Center - leader.Center).ToLengthAndAngle();
			AngleToLeader = angle - WAngle.FromFacing(leader.Angle.Facing);
			DistanceToLeader = length;

			UpdateFormation(leader, PositionNumber);
		}

		protected override void OnLeaderChanged(Unit self, Mobile? oldLeader, Mobile? newLeader)
		{
			if (newLeader is not null)
				DetermineAngleAndDistanceToLeader(newLeader);
		}

		private IEnumerable<WRect> GetHitBoxes()
		{
			var (size, halfSize) = (Options.HitBoxSize, Options.HitBoxSize / 2);

			switch (Angle.Quantize())
			{
				case 3:
				case 7:
					for (var i = 0; i < 5; i++)
					{
						var offset = i * halfSize;
						yield return WRect.FromCenter(Center + new WVec(size - offset, -size + offset), new WVec(size, size));
					}
					break;

				case 1:
				case 5:
					for (var i = 0; i < 5; i++)
					{
						var offset = i * halfSize;
						yield return WRect.FromCenter(Center + new WVec(-size + offset, -size + offset), new WVec(size, size));
					}
					break;

				case 2:
				case 6:
					for (var i = 0; i < 3; i++)
					{
						var offset = i * size;
						yield return WRect.FromCenter(Center + new WVec(0, -size + offset), new WVec(size, size));
					}
					break;

				case 0:
				case 4:
					for (var i = 0; i < 3; i++)
					{
						var offset = i * size;
						yield return WRect.FromCenter(Center + new WVec(-size + offset, 0), new WVec(size, size));
					}
					break;
			}
		}

		public bool Contains(WPos value) => GetHitBoxes().Any(hitBox => hitBox.Contains(value));

		private void DrawHitBoxes(Graphics graphics, Camera camera)
		{
			foreach (var hitBox in GetHitBoxes())
			{
				graphics.DrawRectangle(new DPen(DColor.Yellow), camera.WorldToScreen(hitBox).ToRectangle().ToDrawingRectangle());
			}
		}

		void IDrawable.Draw(Unit self, Graphics graphics, Camera camera)
		{
#if DEBUG
			DrawHitBoxes(graphics, camera);
#endif
		}
	}
}
