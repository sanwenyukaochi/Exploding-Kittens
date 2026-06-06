using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	[Serializable]
	[ComVisible(true)]
	public abstract class Calendar : ICloneable
	{
		internal const long TicksPerMillisecond = 10000L;

		internal const long TicksPerSecond = 10000000L;

		internal const long TicksPerMinute = 600000000L;

		internal const long TicksPerHour = 36000000000L;

		internal const long TicksPerDay = 864000000000L;

		internal const int MillisPerSecond = 1000;

		internal const int MillisPerMinute = 60000;

		internal const int MillisPerHour = 3600000;

		internal const int MillisPerDay = 86400000;

		internal const int DaysPerYear = 365;

		internal const int DaysPer4Years = 1461;

		internal const int DaysPer100Years = 36524;

		internal const int DaysPer400Years = 146097;

		internal const int DaysTo10000 = 3652059;

		internal const long MaxMillis = 315537897600000L;

		internal const int CAL_GREGORIAN = 1;

		internal const int CAL_GREGORIAN_US = 2;

		internal const int CAL_JAPAN = 3;

		internal const int CAL_TAIWAN = 4;

		internal const int CAL_KOREA = 5;

		internal const int CAL_HIJRI = 6;

		internal const int CAL_THAI = 7;

		internal const int CAL_HEBREW = 8;

		internal const int CAL_GREGORIAN_ME_FRENCH = 9;

		internal const int CAL_GREGORIAN_ARABIC = 10;

		internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

		internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

		internal const int CAL_JULIAN = 13;

		internal const int CAL_JAPANESELUNISOLAR = 14;

		internal const int CAL_CHINESELUNISOLAR = 15;

		internal const int CAL_SAKA = 16;

		internal const int CAL_LUNAR_ETO_CHN = 17;

		internal const int CAL_LUNAR_ETO_KOR = 18;

		internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

		internal const int CAL_KOREANLUNISOLAR = 20;

		internal const int CAL_TAIWANLUNISOLAR = 21;

		internal const int CAL_PERSIAN = 22;

		internal const int CAL_UMALQURA = 23;

		internal int m_currentEraValue;

		[OptionalField(VersionAdded = 2)]
		private bool m_isReadOnly;

		public const int CurrentEra = 0;

		internal int twoDigitYearMax;

		[ComVisible(false)]
		public virtual DateTime MinSupportedDateTime => default(DateTime);

		[ComVisible(false)]
		public virtual DateTime MaxSupportedDateTime => default(DateTime);

		internal virtual int ID => 0;

		internal virtual int BaseCalendarID => 0;

		[ComVisible(false)]
		public bool IsReadOnly => false;

		internal virtual int CurrentEraValue => 0;

		public abstract int[] Eras { get; }

		public virtual int TwoDigitYearMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[ComVisible(false)]
		public virtual object Clone()
		{
			return null;
		}

		[ComVisible(false)]
		public static Calendar ReadOnly(Calendar calendar)
		{
			return null;
		}

		internal void VerifyWritable()
		{
		}

		internal void SetReadOnlyState(bool readOnly)
		{
		}

		public abstract int GetDayOfMonth(DateTime time);

		public abstract DayOfWeek GetDayOfWeek(DateTime time);

		public abstract int GetDaysInMonth(int year, int month, int era);

		public abstract int GetDaysInYear(int year, int era);

		public abstract int GetEra(DateTime time);

		public abstract int GetMonth(DateTime time);

		public abstract int GetMonthsInYear(int year, int era);

		public abstract int GetYear(DateTime time);

		public virtual bool IsLeapYear(int year)
		{
			return false;
		}

		public abstract bool IsLeapYear(int year, int era);

		public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			return default(DateTime);
		}

		public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

		internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			result = default(DateTime);
			return false;
		}

		internal virtual bool IsValidYear(int year, int era)
		{
			return false;
		}

		internal virtual bool IsValidMonth(int year, int month, int era)
		{
			return false;
		}

		internal virtual bool IsValidDay(int year, int month, int day, int era)
		{
			return false;
		}

		public virtual int ToFourDigitYear(int year)
		{
			return 0;
		}

		internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			return 0L;
		}

		internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
		{
			return 0;
		}
	}
}
