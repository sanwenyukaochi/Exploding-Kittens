using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public readonly struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
	{
		private const long TicksPerMillisecond = 10000L;

		private const long TicksPerSecond = 10000000L;

		private const long TicksPerMinute = 600000000L;

		private const long TicksPerHour = 36000000000L;

		private const long TicksPerDay = 864000000000L;

		private const int MillisPerSecond = 1000;

		private const int MillisPerMinute = 60000;

		private const int MillisPerHour = 3600000;

		private const int MillisPerDay = 86400000;

		private const int DaysPerYear = 365;

		private const int DaysPer4Years = 1461;

		private const int DaysPer100Years = 36524;

		private const int DaysPer400Years = 146097;

		private const int DaysTo1601 = 584388;

		private const int DaysTo1899 = 693593;

		internal const int DaysTo1970 = 719162;

		private const int DaysTo10000 = 3652059;

		internal const long MinTicks = 0L;

		internal const long MaxTicks = 3155378975999999999L;

		private const long MaxMillis = 315537897600000L;

		internal const long UnixEpochTicks = 621355968000000000L;

		private const long FileTimeOffset = 504911232000000000L;

		private const long DoubleDateOffset = 599264352000000000L;

		private const long OADateMinAsTicks = 31241376000000000L;

		private const double OADateMinAsDouble = -657435.0;

		private const double OADateMaxAsDouble = 2958466.0;

		private const int DatePartYear = 0;

		private const int DatePartDayOfYear = 1;

		private const int DatePartMonth = 2;

		private const int DatePartDay = 3;

		private static readonly int[] s_daysToMonth365;

		private static readonly int[] s_daysToMonth366;

		public static readonly DateTime MinValue;

		public static readonly DateTime MaxValue;

		public static readonly DateTime UnixEpoch;

		private const ulong TicksMask = 4611686018427387903uL;

		private const ulong FlagsMask = 13835058055282163712uL;

		private const ulong LocalMask = 9223372036854775808uL;

		private const long TicksCeiling = 4611686018427387904L;

		private const ulong KindUnspecified = 0uL;

		private const ulong KindUtc = 4611686018427387904uL;

		private const ulong KindLocal = 9223372036854775808uL;

		private const ulong KindLocalAmbiguousDst = 13835058055282163712uL;

		private const int KindShift = 62;

		private const string TicksField = "ticks";

		private const string DateDataField = "dateData";

		private readonly ulong _dateData;

		internal long InternalTicks => 0L;

		private ulong InternalKind => 0uL;

		public DateTime Date => default(DateTime);

		public int Day => 0;

		public DayOfWeek DayOfWeek => default(DayOfWeek);

		public int Hour => 0;

		public DateTimeKind Kind => default(DateTimeKind);

		public int Millisecond => 0;

		public int Minute => 0;

		public int Month => 0;

		public static DateTime Now => default(DateTime);

		public int Second => 0;

		public long Ticks => 0L;

		public TimeSpan TimeOfDay => default(TimeSpan);

		public int Year => 0;

		public static DateTime UtcNow => default(DateTime);

		public DateTime(long ticks)
		{
			_dateData = 0uL;
		}

		private DateTime(ulong dateData)
		{
			_dateData = 0uL;
		}

		public DateTime(long ticks, DateTimeKind kind)
		{
			_dateData = 0uL;
		}

		internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			_dateData = 0uL;
		}

		public DateTime(int year, int month, int day)
		{
			_dateData = 0uL;
		}

		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			_dateData = 0uL;
		}

		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			_dateData = 0uL;
		}

		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			_dateData = 0uL;
		}

		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
		{
			_dateData = 0uL;
		}

		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
		{
			_dateData = 0uL;
		}

		private DateTime(SerializationInfo info, StreamingContext context)
		{
			_dateData = 0uL;
		}

		public DateTime Add(TimeSpan value)
		{
			return default(DateTime);
		}

		private DateTime Add(double value, int scale)
		{
			return default(DateTime);
		}

		public DateTime AddDays(double value)
		{
			return default(DateTime);
		}

		public DateTime AddMilliseconds(double value)
		{
			return default(DateTime);
		}

		public DateTime AddMonths(int months)
		{
			return default(DateTime);
		}

		public DateTime AddSeconds(double value)
		{
			return default(DateTime);
		}

		public DateTime AddTicks(long value)
		{
			return default(DateTime);
		}

		public DateTime AddYears(int value)
		{
			return default(DateTime);
		}

		public static int Compare(DateTime t1, DateTime t2)
		{
			return 0;
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(DateTime value)
		{
			return 0;
		}

		private static long DateToTicks(int year, int month, int day)
		{
			return 0L;
		}

		private static long TimeToTicks(int hour, int minute, int second)
		{
			return 0L;
		}

		public static int DaysInMonth(int year, int month)
		{
			return 0;
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public bool Equals(DateTime value)
		{
			return false;
		}

		public static DateTime FromBinary(long dateData)
		{
			return default(DateTime);
		}

		internal static DateTime FromBinaryRaw(long dateData)
		{
			return default(DateTime);
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			return default(DateTime);
		}

		private int GetDatePart(int part)
		{
			return 0;
		}

		internal void GetDatePart(out int year, out int month, out int day)
		{
			year = default(int);
			month = default(int);
			day = default(int);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal bool IsAmbiguousDaylightSavingTime()
		{
			return false;
		}

		public static bool IsLeapYear(int year)
		{
			return false;
		}

		public static DateTime Parse(string s)
		{
			return default(DateTime);
		}

		public static DateTime Parse(string s, IFormatProvider provider)
		{
			return default(DateTime);
		}

		public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
		{
			return default(DateTime);
		}

		public static DateTime ParseExact(string s, string format, IFormatProvider provider)
		{
			return default(DateTime);
		}

		public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			return default(DateTime);
		}

		public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
		{
			return default(DateTime);
		}

		public TimeSpan Subtract(DateTime value)
		{
			return default(TimeSpan);
		}

		public DateTime ToLocalTime()
		{
			return default(DateTime);
		}

		internal DateTime ToLocalTime(bool throwOnOverflow)
		{
			return default(DateTime);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			charsWritten = default(int);
			return false;
		}

		public DateTime ToUniversalTime()
		{
			return default(DateTime);
		}

		public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			result = default(DateTime);
			return false;
		}

		public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			result = default(DateTime);
			return false;
		}

		public static DateTime operator +(DateTime d, TimeSpan t)
		{
			return default(DateTime);
		}

		public static DateTime operator -(DateTime d, TimeSpan t)
		{
			return default(DateTime);
		}

		public static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			return default(TimeSpan);
		}

		public static bool operator ==(DateTime d1, DateTime d2)
		{
			return false;
		}

		public static bool operator !=(DateTime d1, DateTime d2)
		{
			return false;
		}

		public static bool operator <(DateTime t1, DateTime t2)
		{
			return false;
		}

		public static bool operator <=(DateTime t1, DateTime t2)
		{
			return false;
		}

		public static bool operator >(DateTime t1, DateTime t2)
		{
			return false;
		}

		public static bool operator >=(DateTime t1, DateTime t2)
		{
			return false;
		}

		public TypeCode GetTypeCode()
		{
			return default(TypeCode);
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return false;
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return '\0';
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return 0;
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return 0;
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return 0;
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return 0;
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return 0u;
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return 0uL;
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return 0f;
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return 0.0;
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return default(decimal);
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return null;
		}

		internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
		{
			result = default(DateTime);
			return false;
		}

		internal static long GetSystemTimeAsFileTime()
		{
			return 0L;
		}

		internal long ToBinaryRaw()
		{
			return 0L;
		}
	}
}
