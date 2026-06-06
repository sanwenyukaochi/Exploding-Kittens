namespace System.Globalization
{
	[Serializable]
	public class UmAlQuraCalendar : Calendar
	{
		internal struct DateMapping
		{
			internal int HijriMonthsLengthFlags;

			internal DateTime GregorianDate;

			internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
				HijriMonthsLengthFlags = 0;
				GregorianDate = default(DateTime);
			}
		}

		private static readonly DateMapping[] HijriYearInfo;

		internal static DateTime minDate;

		internal static DateTime maxDate;

		public override DateTime MinSupportedDateTime => default(DateTime);

		public override DateTime MaxSupportedDateTime => default(DateTime);

		internal override int BaseCalendarID => 0;

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

		private static DateMapping[] InitDateMapping()
		{
			return null;
		}

		private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
		{
		}

		private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			return 0L;
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

		private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
		{
		}

		internal virtual int GetDatePart(DateTime time, int part)
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

		internal static int RealGetDaysInYear(int year)
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
