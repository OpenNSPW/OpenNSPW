using System.Diagnostics.CodeAnalysis;
using Microsoft.Xna.Framework;

namespace OpenNspw;

internal static class WPosExtensions
{
	public static WPos FlipY(this WPos value, bool flipY = true) => flipY ? new WPos(value.X, -value.Y) : value;
}

internal static class WVecExtensions
{
	public static WVec FlipY(this WVec value, bool flipY = true) => flipY ? new WVec(value.X, -value.Y) : value;

	public static (float Length, WAngle Angle) ToLengthAndAngle(this WVec value) => (value.Length, WAngle.FromVector(value));
}

internal static class WAngleExtensions
{
	public static int Quantize(this WAngle value) => (value.Facing + 1) % 16 / 2;

	// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Mods.Common/Util.cs#L91
	public static bool IsWithinTolerance(this WAngle angle, WAngle desiredAngle, WAngle angleTolerance)
	{
		if (angleTolerance.Degrees == 0 && angle == desiredAngle)
			return true;

		var delta = (desiredAngle - angle).Degrees;
		return delta <= angleTolerance.Degrees || delta >= 360 - angleTolerance.Degrees;
	}
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

// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Exts.cs#L582
internal static class Enum<T>
{
	public static T Parse(string s) => (T)Enum.Parse(typeof(T), s);
	public static T[] GetValues() => (T[])Enum.GetValues(typeof(T));

	public static bool TryParse(string s, bool ignoreCase, [NotNullWhen(true)] out T? value)
	{
		// The string may be a comma delimited list of values
		var names = ignoreCase ? Enum.GetNames(typeof(T)).Select(x => x.ToLowerInvariant()) : Enum.GetNames(typeof(T));
		var values = ignoreCase ? s.Split(',').Select(x => x.Trim().ToLowerInvariant()) : s.Split(',').Select(x => x.Trim());

		if (values.Any(x => !names.Contains(x)))
		{
			value = default;
			return false;
		}

		value = (T)Enum.Parse(typeof(T), s, ignoreCase);

		return true;
	}
}

// Code from: https://stackoverflow.com/questions/19178774/force-creating-lazy-objects/66855254#66855254
internal static class LazyExtensions
{
	public static Lazy<T> ForceInitialize<T>(this Lazy<T> lazy)
	{
		if (lazy is null) throw new ArgumentNullException(nameof(lazy));

		_ = lazy.Value;
		return lazy;
	}
}

// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/Primitives/TypeDictionary.cs#L114
internal static class TypeExtensions
{
	public static IEnumerable<Type> GetBaseTypes(this Type? type)
	{
		while (type is not null)
		{
			yield return type;
			type = type.BaseType;
		}
	}
}

// Code from: https://github.com/OpenRA/OpenRA/blob/6810469634d43a7a3e8ab2664942e162c3f4436a/OpenRA.Game/TraitDictionary.cs#L20
internal static class ListExtensions
{
	public static int BinarySearchMany(this List<Unit> units, int id)
	{
		var start = 0;
		var end = units.Count;
		while (start != end)
		{
			var mid = (start + end) / 2;
			if (units[mid].Id < id)
				start = mid + 1;
			else
				end = mid;
		}

		return start;
	}
}
