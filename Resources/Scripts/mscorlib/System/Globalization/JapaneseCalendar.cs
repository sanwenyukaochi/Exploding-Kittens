using System.Runtime.InteropServices;

namespace System.Globalization
{
	[Serializable]
	[ComVisible(true)]
	public class JapaneseCalendar : Calendar
	{
		internal static readonly DateTime calendarMinValue;

		internal static EraInfo[] japaneseEraInfo;

		internal static Calendar s_defaultInstance;

		internal GregorianCalendarHelper helper;

		[ComVisible(false)]
		public override DateTime MinSupportedDateTime => default(DateTime);

		[ComVisible(false)]
		public override DateTime MaxSupportedDateTime => default(DateTime);

		internal override int ID => 0;

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

		internal static EraInfo[] GetEraInfo()
		{
			return null;
		}

		private static EraInfo[] GetErasFromRegistry()
		{
			return null;
		}

		internal static Calendar GetDefaultInstance()
		{
			return null;
		}

		public override int GetDaysInMonth(int year, int month, int era)
		{
			return 0;
		}

		public override int GetDaysInYear(int year, int era)
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

		public override int GetMonthsInYear(int year, int era)
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

		internal static string[] EraNames()
		{
			return null;
		}

		internal static string[] EnglishEraNames()
		{
			return null;
		}

		internal override bool IsValidYear(int year, int era)
		{
			return false;
		}
	}
}
