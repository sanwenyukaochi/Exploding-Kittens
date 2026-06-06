using System.Text.RegularExpressions;

namespace System.Xml
{
	public class XmlConvert
	{
		private static XmlCharType xmlCharType;

		internal static char[] crt;

		private static readonly int c_EncodedCharLength;

		private static Regex c_EncodeCharPattern;

		private static Regex c_DecodeCharPattern;

		private static string[] s_allDateTimeFormats;

		internal static readonly char[] WhitespaceChars;

		private static string[] AllDateTimeFormats => null;

		public static string EncodeName(string name)
		{
			return null;
		}

		public static string EncodeLocalName(string name)
		{
			return null;
		}

		public static string DecodeName(string name)
		{
			return null;
		}

		private static string EncodeName(string name, bool first, bool local)
		{
			return null;
		}

		private static int FromHex(char digit)
		{
			return 0;
		}

		internal static byte[] FromBinHexString(string s)
		{
			return null;
		}

		internal static byte[] FromBinHexString(string s, bool allowOddCount)
		{
			return null;
		}

		internal static string ToBinHexString(byte[] inArray)
		{
			return null;
		}

		public static string VerifyName(string name)
		{
			return null;
		}

		internal static Exception TryVerifyName(string name)
		{
			return null;
		}

		internal static string VerifyQName(string name, ExceptionType exceptionType)
		{
			return null;
		}

		public static string VerifyNCName(string name)
		{
			return null;
		}

		internal static string VerifyNCName(string name, ExceptionType exceptionType)
		{
			return null;
		}

		internal static Exception TryVerifyNCName(string name)
		{
			return null;
		}

		public static string VerifyTOKEN(string token)
		{
			return null;
		}

		internal static Exception TryVerifyTOKEN(string token)
		{
			return null;
		}

		internal static Exception TryVerifyNMTOKEN(string name)
		{
			return null;
		}

		internal static Exception TryVerifyNormalizedString(string str)
		{
			return null;
		}

		public static string ToString(bool value)
		{
			return null;
		}

		public static string ToString(char value)
		{
			return null;
		}

		public static string ToString(decimal value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return null;
		}

		public static string ToString(short value)
		{
			return null;
		}

		public static string ToString(int value)
		{
			return null;
		}

		public static string ToString(long value)
		{
			return null;
		}

		public static string ToString(byte value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return null;
		}

		public static string ToString(float value)
		{
			return null;
		}

		public static string ToString(double value)
		{
			return null;
		}

		public static string ToString(TimeSpan value)
		{
			return null;
		}

		public static string ToString(DateTime value, string format)
		{
			return null;
		}

		public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
		{
			return null;
		}

		public static string ToString(DateTimeOffset value)
		{
			return null;
		}

		public static string ToString(Guid value)
		{
			return null;
		}

		public static bool ToBoolean(string s)
		{
			return false;
		}

		internal static Exception TryToBoolean(string s, out bool result)
		{
			result = default(bool);
			return null;
		}

		public static char ToChar(string s)
		{
			return '\0';
		}

		internal static Exception TryToChar(string s, out char result)
		{
			result = default(char);
			return null;
		}

		public static decimal ToDecimal(string s)
		{
			return default(decimal);
		}

		internal static Exception TryToDecimal(string s, out decimal result)
		{
			result = default(decimal);
			return null;
		}

		internal static decimal ToInteger(string s)
		{
			return default(decimal);
		}

		internal static Exception TryToInteger(string s, out decimal result)
		{
			result = default(decimal);
			return null;
		}

		[CLSCompliant(false)]
		public static sbyte ToSByte(string s)
		{
			return 0;
		}

		internal static Exception TryToSByte(string s, out sbyte result)
		{
			result = default(sbyte);
			return null;
		}

		public static short ToInt16(string s)
		{
			return 0;
		}

		internal static Exception TryToInt16(string s, out short result)
		{
			result = default(short);
			return null;
		}

		public static int ToInt32(string s)
		{
			return 0;
		}

		internal static Exception TryToInt32(string s, out int result)
		{
			result = default(int);
			return null;
		}

		public static long ToInt64(string s)
		{
			return 0L;
		}

		internal static Exception TryToInt64(string s, out long result)
		{
			result = default(long);
			return null;
		}

		public static byte ToByte(string s)
		{
			return 0;
		}

		internal static Exception TryToByte(string s, out byte result)
		{
			result = default(byte);
			return null;
		}

		[CLSCompliant(false)]
		public static ushort ToUInt16(string s)
		{
			return 0;
		}

		internal static Exception TryToUInt16(string s, out ushort result)
		{
			result = default(ushort);
			return null;
		}

		[CLSCompliant(false)]
		public static uint ToUInt32(string s)
		{
			return 0u;
		}

		internal static Exception TryToUInt32(string s, out uint result)
		{
			result = default(uint);
			return null;
		}

		[CLSCompliant(false)]
		public static ulong ToUInt64(string s)
		{
			return 0uL;
		}

		internal static Exception TryToUInt64(string s, out ulong result)
		{
			result = default(ulong);
			return null;
		}

		public static float ToSingle(string s)
		{
			return 0f;
		}

		internal static Exception TryToSingle(string s, out float result)
		{
			result = default(float);
			return null;
		}

		public static double ToDouble(string s)
		{
			return 0.0;
		}

		internal static Exception TryToDouble(string s, out double result)
		{
			result = default(double);
			return null;
		}

		internal static double ToXPathDouble(object o)
		{
			return 0.0;
		}

		public static TimeSpan ToTimeSpan(string s)
		{
			return default(TimeSpan);
		}

		internal static Exception TryToTimeSpan(string s, out TimeSpan result)
		{
			result = default(TimeSpan);
			return null;
		}

		private static void CreateAllDateTimeFormats()
		{
		}

		[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
		public static DateTime ToDateTime(string s)
		{
			return default(DateTime);
		}

		public static DateTime ToDateTime(string s, string[] formats)
		{
			return default(DateTime);
		}

		public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption)
		{
			return default(DateTime);
		}

		public static DateTimeOffset ToDateTimeOffset(string s)
		{
			return default(DateTimeOffset);
		}

		public static Guid ToGuid(string s)
		{
			return default(Guid);
		}

		internal static Exception TryToGuid(string s, out Guid result)
		{
			result = default(Guid);
			return null;
		}

		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default(DateTime);
		}

		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default(DateTime);
		}

		internal static Uri ToUri(string s)
		{
			return null;
		}

		internal static Exception TryToUri(string s, out Uri result)
		{
			result = null;
			return null;
		}

		internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2)
		{
			return false;
		}

		internal static string TrimString(string value)
		{
			return null;
		}

		internal static string TrimStringStart(string value)
		{
			return null;
		}

		internal static string TrimStringEnd(string value)
		{
			return null;
		}

		internal static string[] SplitString(string value)
		{
			return null;
		}

		internal static bool IsNegativeZero(double value)
		{
			return false;
		}

		private static long DoubleToInt64Bits(double value)
		{
			return 0L;
		}

		internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType)
		{
		}

		internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos)
		{
			return null;
		}

		internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
		{
			return null;
		}

		internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType)
		{
			return null;
		}

		internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos)
		{
			return null;
		}

		internal static Exception CreateInvalidSurrogatePairException(char low, char hi)
		{
			return null;
		}

		internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
		{
			return null;
		}

		internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			return null;
		}

		internal static Exception CreateInvalidHighSurrogateCharException(char hi)
		{
			return null;
		}

		internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
		{
			return null;
		}

		internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			return null;
		}

		internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType)
		{
			return null;
		}

		internal static Exception CreateInvalidCharException(char invChar, char nextChar)
		{
			return null;
		}

		internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType)
		{
			return null;
		}

		internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
		{
			return null;
		}

		internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
		{
			return null;
		}
	}
}
