using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlBoolean : INullable, IComparable, IXmlSerializable
	{
		private byte m_value;

		public static readonly SqlBoolean True;

		public static readonly SqlBoolean False;

		public static readonly SqlBoolean Null;

		public static readonly SqlBoolean Zero;

		public static readonly SqlBoolean One;

		public bool IsNull => false;

		public bool Value => false;

		public bool IsTrue => false;

		public bool IsFalse => false;

		public byte ByteValue => 0;

		public SqlBoolean(bool value)
		{
			m_value = 0;
		}

		public SqlBoolean(int value)
		{
			m_value = 0;
		}

		private SqlBoolean(int value, bool fNull)
		{
			m_value = 0;
		}

		public static implicit operator SqlBoolean(bool x)
		{
			return default(SqlBoolean);
		}

		public static bool operator true(SqlBoolean x)
		{
			return false;
		}

		public static SqlBoolean operator &(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator |(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlBoolean operator ==(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean And(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean Or(SqlBoolean x, SqlBoolean y)
		{
			return default(SqlBoolean);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlBoolean value)
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
