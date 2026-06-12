using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDouble : INullable, IComparable, IXmlSerializable
	{
		private bool m_fNotNull;

		private double m_value;

		public static readonly SqlDouble Null;

		public static readonly SqlDouble Zero;

		public static readonly SqlDouble MinValue;

		public static readonly SqlDouble MaxValue;

		public bool IsNull => false;

		public double Value => 0.0;

		private SqlDouble(bool fNull)
		{
			m_fNotNull = false;
			m_value = 0.0;
		}

		public SqlDouble(double value)
		{
			m_fNotNull = false;
			m_value = 0.0;
		}

		public static implicit operator SqlDouble(double x)
		{
			return default(SqlDouble);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlDouble operator -(SqlDouble x)
		{
			return default(SqlDouble);
		}

		public static SqlDouble operator +(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		public static SqlDouble operator -(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		public static SqlDouble operator *(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		public static SqlDouble operator /(SqlDouble x, SqlDouble y)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlByte x)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlInt16 x)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlInt32 x)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlInt64 x)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlSingle x)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlMoney x)
		{
			return default(SqlDouble);
		}

		public static implicit operator SqlDouble(SqlDecimal x)
		{
			return default(SqlDouble);
		}

		public static SqlBoolean operator ==(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean LessThan(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y)
		{
			return default(SqlBoolean);
		}

		public SqlSingle ToSqlSingle()
		{
			return default(SqlSingle);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlDouble value)
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
