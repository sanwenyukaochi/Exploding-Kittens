using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	[DefaultMember("Item")]
	public struct SqlBinary : INullable, IComparable, IXmlSerializable
	{
		private byte[] _value;

		public static readonly SqlBinary Null;

		public bool IsNull => false;

		public byte[] Value => null;

		private SqlBinary(bool fNull)
		{
			_value = null;
		}

		public SqlBinary(byte[] value)
		{
			_value = null;
		}

		public static implicit operator SqlBinary(byte[] x)
		{
			return default(SqlBinary);
		}

		public override string ToString()
		{
			return null;
		}

		private static EComparison PerformCompareByte(byte[] x, byte[] y)
		{
			return default(EComparison);
		}

		public static SqlBoolean operator ==(SqlBinary x, SqlBinary y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlBinary x, SqlBinary y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlBinary x, SqlBinary y)
		{
			return default(SqlBoolean);
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlBinary value)
		{
			return 0;
		}

		public override bool Equals(object value)
		{
			return false;
		}

		internal static int HashByteArray(byte[] rgbValue, int length)
		{
			return 0;
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
