using Microsoft.Xna.Framework;

namespace OpenNspw
{
	internal static class WPosExtensions
	{
		public static WPos FlipY(this WPos value, bool flipY = true) => flipY ? new WPos(value.X, -value.Y) : value;
	}

	internal static class WVecExtensions
	{
		public static WVec FlipY(this WVec value, bool flipY = true) => flipY ? new WVec(value.X, -value.Y) : value;
	}

	internal static class WAngleExtensions
	{
		public static int Quantize(this WAngle value) => (value.Facing + 1) % 16 / 2;
	}

	internal static class RectangleExtensions
	{
		public static bool Contains(this Rectangle rectangle, CPos value) => value.X >= rectangle.Left && value.X <= rectangle.Right && value.Y >= rectangle.Top && value.Y <= rectangle.Bottom;
	}
}
