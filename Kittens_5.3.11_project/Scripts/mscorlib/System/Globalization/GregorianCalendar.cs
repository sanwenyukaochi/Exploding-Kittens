using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	[Serializable]
	[ComVisible(true)]
	public class GregorianCalendar : Calendar
	{
		internal GregorianCalendarTypes m_type;

		internal static readonly int[] DaysToMonth365;

		internal static readonly int[] DaysToMonth366;

		private static Calendar s_defaultInstance;

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

		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		internal static Calendar GetDefaultInstance()
		{
			return null;
		}

		public GregorianCalendar()
		{
		}

		public GregorianCalendar(GregorianCalendarTypes type)
		{
		}

		internal virtual int GetDatePart(long ticks, int part)
		{
			return 0;
		}

		internal static long GetAbsoluteDate(int year, int month, int day)
		{
			return 0L;
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

		internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
		{
			result = default(DateTime);
			return false;
		}

		public override int ToFourDigitYear(int year)
		{
			return 0;
		}
	}
}
