using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDateTime : INullable, IComparable, IXmlSerializable
	{
		private bool m_fNotNull;

		private int m_day;

		private int m_time;

		private static readonly double s_SQLTicksPerMillisecond;

		public static readonly int SQLTicksPerSecond;

		public static readonly int SQLTicksPerMinute;

		public static readonly int SQLTicksPerHour;

		private static readonly int s_SQLTicksPerDay;

		private static readonly long s_ticksPerSecond;

		private static readonly DateTime s_SQLBaseDate;

		private static readonly long s_SQLBaseDateTicks;

		private static readonly int s_minYear;

		private static readonly int s_maxYear;

		private static readonly int s_minDay;

		private static readonly int s_maxDay;

		private static readonly int s_minTime;

		private static readonly int s_maxTime;

		private static readonly int s_dayBase;

		private static readonly int[] s_daysToMonth365;

		private static readonly int[] s_daysToMonth366;

		private static readonly DateTime s_minDateTime;

		private static readonly DateTime s_maxDateTime;

		private static readonly TimeSpan s_minTimeSpan;

		private static readonly TimeSpan s_maxTimeSpan;

		private static readonly string s_ISO8601_DateTimeFormat;

		private static readonly string[] s_dateTimeFormats;

		public static readonly SqlDateTime MinValue;

		public static readonly SqlDateTime MaxValue;

		public static readonly SqlDateTime Null;

		public bool IsNull => false;

		public DateTime Value => default(DateTime);

		public int DayTicks => 0;

		public int TimeTicks => 0;

		private SqlDateTime(bool fNull)
		{
			m_fNotNull = false;
			m_day = 0;
			m_time = 0;
		}

		public SqlDateTime(DateTime value)
		{
			m_fNotNull = false;
			m_day = 0;
			m_time = 0;
		}

		public SqlDateTime(int dayTicks, int timeTicks)
		{
			m_fNotNull = false;
			m_day = 0;
			m_time = 0;
		}

		private static TimeSpan ToTimeSpan(SqlDateTime value)
		{
			return default(TimeSpan);
		}

		private static DateTime ToDateTime(SqlDateTime value)
		{
			return default(DateTime);
		}

		private static SqlDateTime FromTimeSpan(TimeSpan value)
		{
			return default(SqlDateTime);
		}

		private static SqlDateTime FromDateTime(DateTime value)
		{
			return default(SqlDateTime);
		}

		public static implicit operator SqlDateTime(DateTime value)
		{
			return default(SqlDateTime);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlBoolean operator ==(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y)
		{
			return default(SqlBoolean);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlDateTime value)
		{
			return 0;
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
}
