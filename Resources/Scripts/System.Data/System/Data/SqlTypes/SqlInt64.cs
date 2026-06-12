using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt64 : INullable, IComparable, IXmlSerializable
	{
		private bool m_fNotNull;

		private long m_value;

		private static readonly long s_lLowIntMask;

		private static readonly long s_lHighIntMask;

		public static readonly SqlInt64 Null;

		public static readonly SqlInt64 Zero;

		public static readonly SqlInt64 MinValue;

		public static readonly SqlInt64 MaxValue;

		public bool IsNull => false;

		public long Value => 0L;

		private SqlInt64(bool fNull)
		{
			m_fNotNull = false;
			m_value = 0L;
		}

		public SqlInt64(long value)
		{
			m_fNotNull = false;
			m_value = 0L;
		}

		public static implicit operator SqlInt64(long x)
		{
			return default(SqlInt64);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlInt64 operator -(SqlInt64 x)
		{
			return default(SqlInt64);
		}

		public static SqlInt64 operator +(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		public static SqlInt64 operator -(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		public static SqlInt64 operator *(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		public static SqlInt64 operator /(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		public static SqlInt64 operator %(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlInt64);
		}

		public static implicit operator SqlInt64(SqlByte x)
		{
			return default(SqlInt64);
		}

		public static implicit operator SqlInt64(SqlInt16 x)
		{
			return default(SqlInt64);
		}

		public static implicit operator SqlInt64(SqlInt32 x)
		{
			return default(SqlInt64);
		}

		public static explicit operator SqlInt64(SqlDecimal x)
		{
			return default(SqlInt64);
		}

		private static bool SameSignLong(long x, long y)
		{
			return false;
		}

		public static SqlBoolean operator ==(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y)
		{
			return default(SqlBoolean);
		}

		public SqlByte ToSqlByte()
		{
			return default(SqlByte);
		}

		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		public SqlInt16 ToSqlInt16()
		{
			return default(SqlInt16);
		}

		public SqlInt32 ToSqlInt32()
		{
			return default(SqlInt32);
		}

		public SqlDecimal ToSqlDecimal()
		{
			return default(SqlDecimal);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlInt64 value)
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
