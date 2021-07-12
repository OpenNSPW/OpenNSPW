namespace OpenNspw
{
	internal readonly record struct ConditionToken(int Value)
	{
		public static ConditionToken Invalid => default;

		public static ConditionToken operator ++(ConditionToken value) => new(value.Value + 1);

		public bool IsValid => this != Invalid;
	}
}
