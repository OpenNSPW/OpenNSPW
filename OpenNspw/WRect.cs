namespace OpenNspw
{
	internal readonly struct WRect : IEquatable<WRect>
	{
		public WPos Center { get; }
		public WVec Size { get; }

		private WRect(WPos center, WVec size) => (Center, Size) = (center, size);

		public float Left => Center.X - Size.X / 2;
		public float Bottom => Center.Y - Size.Y / 2;
		public float Right => Center.X + Size.X / 2;
		public float Top => Center.Y + Size.Y / 2;

		public WPos BottomLeft => new(Left, Bottom);
		public WPos BottomRight => new(Right, Bottom);
		public WPos TopRight => new(Right, Top);
		public WPos TopLeft => new(Left, Top);

		public static bool operator ==(WRect left, WRect right) => left.Equals(right);
		public static bool operator !=(WRect left, WRect right) => !left.Equals(right);

		public static WRect FromCenter(WPos center, WVec size) => new(center, size);

		public bool Equals(WRect other) => Center == other.Center && Size == other.Size;
		public override bool Equals(object? obj) => obj is WRect other && Equals(other);

		public override int GetHashCode() => (Center, Size).GetHashCode();

		public override string ToString() => $"(X: {Left}, Y: {Bottom}, Width: {Size.X}, Height: {Size.Y})";

		public bool Contains(WPos value) => value.X >= Left && value.X <= Right && value.Y >= Bottom && value.Y <= Top;

		public WRect Inflate(WVec size) => new(Center, Size + size * 2);

		public bool Intersects(WRect value) => value.Left < Right && Left < value.Right && value.Bottom < Top && Bottom < value.Top;
	}
}
