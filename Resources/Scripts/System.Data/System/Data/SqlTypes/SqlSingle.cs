using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlSingle : INullable, IComparable, IXmlSerializable
	{
		private bool _fNotNull;

		private float _value;

		public static readonly SqlSingle Null;

		public static readonly SqlSingle Zero;

		public static readonly SqlSingle MinValue;

		public static readonly SqlSingle MaxValue;

		public bool IsNull => false;

		public float Value => 0f;

		private SqlSingle(bool fNull)
		{
			_fNotNull = false;
			_value = 0f;
		}

		public SqlSingle(float value)
		{
			_fNotNull = false;
			_value = 0f;
		}

		public SqlSingle(double value)
		{
			_fNotNull = false;
			_value = 0f;
		}

		public static implicit operator SqlSingle(float x)
		{
			return default(SqlSingle);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlSingle operator -(SqlSingle x)
		{
			return default(SqlSingle);
		}

		public static SqlSingle operator +(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		public static SqlSingle operator -(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		public static SqlSingle operator *(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		public static SqlSingle operator /(SqlSingle x, SqlSingle y)
		{
			return default(SqlSingle);
		}

		public static implicit operator SqlSingle(SqlByte x)
		{
			return default(SqlSingle);
		}

		public static implicit operator SqlSingle(SqlInt16 x)
		{
			return default(SqlSingle);
		}

		public static implicit operator SqlSingle(SqlInt32 x)
		{
			return default(SqlSingle);
		}

		public static implicit operator SqlSingle(SqlInt64 x)
		{
			return default(SqlSingle);
		}

		public static implicit operator SqlSingle(SqlMoney x)
		{
			return default(SqlSingle);
		}

		public static implicit operator SqlSingle(SqlDecimal x)
		{
			return default(SqlSingle);
		}

		public static explicit operator SqlSingle(SqlDouble x)
		{
			return default(SqlSingle);
		}

		public static SqlBoolean operator ==(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean LessThan(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y)
		{
			return default(SqlBoolean);
		}

		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlSingle value)
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
