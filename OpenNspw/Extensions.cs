using System;
using System.Collections.Generic;
using System.Linq;
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

	internal static class DictionaryExtensions
	{
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key) where TValue : new() => source.GetOrAdd(key, _ => new TValue());

		// Code from: https://github.com/OpenRA/OpenRA/blob/88cdad4189a278e1aab34273b046ab3a1f709a50/OpenRA.Game/Exts.cs#L126
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, Func<TKey, TValue> valueFactory)
		{
			if (!source.TryGetValue(key, out var ret))
				source.Add(key, ret = valueFactory(key));

			return ret;
		}
	}

	internal static class EnumerableExtensions
	{
		// Code from: https://github.com/dotnet/roslyn/blob/8f24ed69cbbf377573c403d6c8febbc92b560343/src/Compilers/Core/Portable/InternalUtilities/EnumerableExtensions.cs#L287
		public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source)
			where T : class
		{
			if (source is null)
				return Array.Empty<T>();

			return source.Where(x => x is not null)!;
		}
	}
}
