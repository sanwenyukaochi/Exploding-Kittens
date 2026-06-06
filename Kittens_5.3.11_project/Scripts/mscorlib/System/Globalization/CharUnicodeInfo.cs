namespace System.Globalization
{
	public static class CharUnicodeInfo
	{
		private static ReadOnlySpan<byte> CategoryLevel1Index => default(ReadOnlySpan<byte>);

		private static ReadOnlySpan<byte> CategoryLevel2Index => default(ReadOnlySpan<byte>);

		private static ReadOnlySpan<byte> CategoryLevel3Index => default(ReadOnlySpan<byte>);

		private static ReadOnlySpan<byte> CategoriesValue => default(ReadOnlySpan<byte>);

		internal static int InternalConvertToUtf32(string s, int index)
		{
			return 0;
		}

		public static UnicodeCategory GetUnicodeCategory(char ch)
		{
			return default(UnicodeCategory);
		}

		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			return default(UnicodeCategory);
		}

		public static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			return default(UnicodeCategory);
		}

		internal static byte InternalGetCategoryValue(int ch, int offset)
		{
			return 0;
		}

		internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			return default(UnicodeCategory);
		}

		internal static bool IsWhiteSpace(string s, int index)
		{
			return false;
		}

		internal static bool IsWhiteSpace(char c)
		{
			return false;
		}
	}
}
