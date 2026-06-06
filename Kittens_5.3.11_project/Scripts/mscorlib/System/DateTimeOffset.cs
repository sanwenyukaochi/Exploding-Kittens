using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public readonly struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
	{
		public static readonly DateTimeOffset MinValue;

		public static readonly DateTimeOffset MaxValue;

		public static readonly DateTimeOffset UnixEpoch;

		private readonly DateTime _dateTime;

		private readonly short _offsetMinutes;

		public static DateTimeOffset Now => default(DateTimeOffset);

		public DateTime DateTime => default(DateTime);

		public DateTime UtcDateTime => default(DateTime);

		public DateTime LocalDateTime => default(DateTime);

		private DateTime ClockDateTime => default(DateTime);

		public int Day => 0;

		public int Hour => 0;

		public int Millisecond => 0;

		public int Minute => 0;

		public int Month => 0;

		public TimeSpan Offset => default(TimeSpan);

		public int Second => 0;

		public long Ticks => 0L;

		public TimeSpan TimeOfDay => default(TimeSpan);

		public int Year => 0;

		public DateTimeOffset(long ticks, TimeSpan offset)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public DateTimeOffset(DateTime dateTime)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public static int Compare(DateTimeOffset first, DateTimeOffset second)
		{
			return 0;
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		public int CompareTo(DateTimeOffset other)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(DateTimeOffset other)
		{
			return false;
		}

		public static DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			return default(DateTimeOffset);
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			_dateTime = default(DateTime);
			_offsetMinutes = 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
		{
			return default(DateTimeOffset);
		}

		public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			return default(DateTimeOffset);
		}

		public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
		{
			return default(DateTimeOffset);
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
		{
			charsWritten = default(int);
			return false;
		}

		public DateTimeOffset ToUniversalTime()
		{
			return default(DateTimeOffset);
		}

		public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			result = default(DateTimeOffset);
			return false;
		}

		public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			result = default(DateTimeOffset);
			return false;
		}

		private static short ValidateOffset(TimeSpan offset)
		{
			return 0;
		}

		private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			return default(DateTime);
		}

		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
		{
			return default(DateTimeStyles);
		}

		public static implicit operator DateTimeOffset(DateTime dateTime)
		{
			return default(DateTimeOffset);
		}

		public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
		{
			return default(TimeSpan);
		}

		public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
		{
			return false;
		}

		public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
		{
			return false;
		}
	}
}
