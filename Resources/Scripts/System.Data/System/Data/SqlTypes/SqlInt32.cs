using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlInt32 : INullable, IComparable, IXmlSerializable
	{
		private bool m_fNotNull;

		private int m_value;

		private static readonly long s_iIntMin;

		private static readonly long s_lBitNotIntMax;

		public static readonly SqlInt32 Null;

		public static readonly SqlInt32 Zero;

		public static readonly SqlInt32 MinValue;

		public static readonly SqlInt32 MaxValue;

		public bool IsNull => false;

		public int Value => 0;

		private SqlInt32(bool fNull)
		{
			m_fNotNull = false;
			m_value = 0;
		}

		public SqlInt32(int value)
		{
			m_fNotNull = false;
			m_value = 0;
		}

		public static implicit operator SqlInt32(int x)
		{
			return default(SqlInt32);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlInt32 operator -(SqlInt32 x)
		{
			return default(SqlInt32);
		}

		public static SqlInt32 operator +(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		public static SqlInt32 operator -(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		public static SqlInt32 operator *(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		public static SqlInt32 operator /(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlInt32);
		}

		public static implicit operator SqlInt32(SqlByte x)
		{
			return default(SqlInt32);
		}

		public static implicit operator SqlInt32(SqlInt16 x)
		{
			return default(SqlInt32);
		}

		public static explicit operator SqlInt32(SqlInt64 x)
		{
			return default(SqlInt32);
		}

		private static bool SameSignInt(int x, int y)
		{
			return false;
		}

		public static SqlBoolean operator ==(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y)
		{
			return default(SqlBoolean);
		}

		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		public SqlInt64 ToSqlInt64()
		{
			return default(SqlInt64);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlInt32 value)
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
