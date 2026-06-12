using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlGuid : INullable, IComparable, IXmlSerializable
	{
		private static readonly int s_sizeOfGuid;

		private static readonly int[] s_rgiGuidOrder;

		private byte[] m_value;

		public static readonly SqlGuid Null;

		public bool IsNull => false;

		public Guid Value => default(Guid);

		private SqlGuid(bool fNull)
		{
			m_value = null;
		}

		public SqlGuid(Guid g)
		{
			m_value = null;
		}

		public static implicit operator SqlGuid(Guid x)
		{
			return default(SqlGuid);
		}

		public override string ToString()
		{
			return null;
		}

		private static EComparison Compare(SqlGuid x, SqlGuid y)
		{
			return default(EComparison);
		}

		public static SqlBoolean operator ==(SqlGuid x, SqlGuid y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlGuid x, SqlGuid y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlGuid x, SqlGuid y)
		{
			return default(SqlBoolean);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlGuid value)
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
