using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	[Serializable]
	[NonVersionable]
	public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
	{
		[Flags]
		private enum GuidStyles
		{
			None = 0,
			AllowParenthesis = 1,
			AllowBraces = 2,
			AllowDashes = 4,
			AllowHexPrefix = 8,
			RequireParenthesis = 0x10,
			RequireBraces = 0x20,
			RequireDashes = 0x40,
			RequireHexPrefix = 0x80,
			HexFormat = 0xA0,
			NumberFormat = 0,
			DigitFormat = 0x40,
			BraceFormat = 0x60,
			ParenthesisFormat = 0x50,
			Any = 0xF
		}

		private enum GuidParseThrowStyle
		{
			None = 0,
			All = 1,
			AllButOverflow = 2
		}

		private enum ParseFailureKind
		{
			None = 0,
			ArgumentNull = 1,
			Format = 2,
			FormatWithParameter = 3,
			NativeException = 4,
			FormatWithInnerException = 5
		}

		private struct GuidResult
		{
			internal Guid _parsedGuid;

			internal GuidParseThrowStyle _throwStyle;

			private ParseFailureKind _failure;

			private string _failureMessageID;

			private object _failureMessageFormatArgument;

			private string _failureArgumentName;

			private Exception _innerException;

			internal void Init(GuidParseThrowStyle canThrow)
			{
			}

			internal void SetFailure(Exception nativeException)
			{
			}

			internal void SetFailure(ParseFailureKind failure, string failureMessageID)
			{
			}

			internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
			}

			internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
			{
			}

			internal Exception GetGuidParseException()
			{
				return null;
			}
		}

		public static readonly Guid Empty;

		private int _a;

		private short _b;

		private short _c;

		private byte _d;

		private byte _e;

		private byte _f;

		private byte _g;

		private byte _h;

		private byte _i;

		private byte _j;

		private byte _k;

		public static Guid NewGuid()
		{
			return default(Guid);
		}

		public Guid(byte[] b)
		{
			_a = 0;
			_b = 0;
			_c = 0;
			_d = 0;
			_e = 0;
			_f = 0;
			_g = 0;
			_h = 0;
			_i = 0;
			_j = 0;
			_k = 0;
		}

		public Guid(ReadOnlySpan<byte> b)
		{
			_a = 0;
			_b = 0;
			_c = 0;
			_d = 0;
			_e = 0;
			_f = 0;
			_g = 0;
			_h = 0;
			_i = 0;
			_j = 0;
			_k = 0;
		}

		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
			_a = 0;
			_b = 0;
			_c = 0;
			_d = 0;
			_e = 0;
			_f = 0;
			_g = 0;
			_h = 0;
			_i = 0;
			_j = 0;
			_k = 0;
		}

		public Guid(string g)
		{
			_a = 0;
			_b = 0;
			_c = 0;
			_d = 0;
			_e = 0;
			_f = 0;
			_g = 0;
			_h = 0;
			_i = 0;
			_j = 0;
			_k = 0;
		}

		public static Guid Parse(string input)
		{
			return default(Guid);
		}

		public static Guid Parse(ReadOnlySpan<char> input)
		{
			return default(Guid);
		}

		public static bool TryParseExact(string input, string format, out Guid result)
		{
			result = default(Guid);
			return false;
		}

		public static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, out Guid result)
		{
			result = default(Guid);
			return false;
		}

		private static bool TryParseGuid(ReadOnlySpan<char> guidString, GuidStyles flags, ref GuidResult result)
		{
			return false;
		}

		private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref GuidResult result)
		{
			return false;
		}

		private static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref GuidResult result)
		{
			return false;
		}

		private static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref GuidResult result)
		{
			return false;
		}

		private static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult)
		{
			result = default(short);
			return false;
		}

		private static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult)
		{
			result = default(short);
			return false;
		}

		private static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult)
		{
			result = default(int);
			return false;
		}

		private static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult)
		{
			result = default(int);
			return false;
		}

		private static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult)
		{
			result = default(long);
			return false;
		}

		private static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str)
		{
			return default(ReadOnlySpan<char>);
		}

		private static bool IsHexPrefix(ReadOnlySpan<char> str, int i)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void WriteByteHelper(Span<byte> destination)
		{
		}

		public byte[] ToByteArray()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public bool Equals(Guid g)
		{
			return false;
		}

		private int GetResult(uint me, uint them)
		{
			return 0;
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(Guid value)
		{
			return 0;
		}

		public static bool operator ==(Guid a, Guid b)
		{
			return false;
		}

		public string ToString(string format)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static char HexToChar(int a)
		{
			return '\0';
		}

		private unsafe static int HexsToChars(char* guidChars, int a, int b)
		{
			return 0;
		}

		private unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
		{
			return 0;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>))
		{
			charsWritten = default(int);
			return false;
		}

		bool ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
		{
			charsWritten = default(int);
			return false;
		}
	}
}
