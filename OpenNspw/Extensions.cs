using Microsoft.Xna.Framework;

namespace OpenNspw
{
	internal static class Extensions
	{
		public static WPos FlipY(this WPos value, bool flipY = true) => flipY ? new WPos(value.X, -value.Y) : value;
		public static WVec FlipY(this WVec value, bool flipY = true) => flipY ? new WVec(value.X, -value.Y) : value;

		public static int Quantize(this WAngle value) => (value.Facing + 1) % 16 / 2;

		public static bool Contains(this Rectangle rectangle, CPos value) => value.X >= rectangle.Left && value.X <= rectangle.Right && value.Y >= rectangle.Top && value.Y <= rectangle.Bottom;
	}
}
