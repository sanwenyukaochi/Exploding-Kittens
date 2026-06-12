using System.Runtime.InteropServices;

namespace System.Globalization
{
	[Serializable]
	[ComVisible(true)]
	public class HijriCalendar : Calendar
	{
		public static readonly int HijriEra;

		internal static readonly int[] HijriMonthDays;

		private int m_HijriAdvance;

		internal static readonly DateTime calendarMinValue;

		internal static readonly DateTime calendarMaxValue;

		[ComVisible(false)]
		public override DateTime MinSupportedDateTime => default(DateTime);

		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime => default(DateTime);

		internal override int ID => 0;

		public int HijriAdjustment => 0;

		public override int[] Eras => null;

		public override int TwoDigitYearMax
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private long GetAbsoluteDateHijri(int y, int m, int d)
		{
			return 0L;
		}

		private long DaysUpToHijriYear(int HijriYear)
		{
			return 0L;
		}

		private static int GetAdvanceHijriDate()
		{
			return 0;
		}

		internal static void CheckTicksRange(long ticks)
		{
		}

		internal static void CheckEraRange(int era)
		{
		}

		internal static void CheckYearRange(int year, int era)
		{
		}

		internal static void CheckYearMonthRange(int year, int month, int era)
		{
		}

		internal virtual int GetDatePart(long ticks, int part)
		{
			return 0;
		}

		public override int GetDayOfMonth(DateTime time)
		{
			return 0;
		}

		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return default(DayOfWeek);
		}

		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		public override int GetDaysInYear(int year, int era)
		{
			return 0;
		}

		public override int GetEra(DateTime time)
		{
			return 0;
		}

		public override int GetMonth(DateTime time)
		{
			return 0;
		}

		public override int GetMonthsInYear(int year, int era)
		{
			return 0;
		}

		public override int GetYear(DateTime time)
		{
			return 0;
		}

		public override bool IsLeapYear(int year, int era)
		{
			return false;
		}

		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			return default(DateTime);
		}

		public override int ToFourDigitYear(int year)
		{
			return 0;
		}
	}
}
