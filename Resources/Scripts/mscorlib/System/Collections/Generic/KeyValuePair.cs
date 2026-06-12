namespace System.Collections.Generic
{
	public static class KeyValuePair
	{
		internal static string PairToString(object key, object value)
		{
			return null;
		}
	}
	[Serializable]
	public readonly struct KeyValuePair<TKey, TValue>
	{
		private readonly TKey key;

		private readonly TValue value;

		public TKey Key => default(TKey);

		public TValue Value => default(TValue);

		public KeyValuePair(TKey key, TValue value)
		{
			this.key = default(TKey);
			this.value = default(TValue);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
