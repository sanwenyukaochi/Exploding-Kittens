using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	[DefaultMember("Item")]
	public sealed class SqlChars : INullable, IXmlSerializable, ISerializable
	{
		internal char[] _rgchBuf;

		private long _lCurLen;

		internal SqlStreamChars _stream;

		private SqlBytesCharsState _state;

		private char[] _rgchWorkBuf;

		public bool IsNull => false;

		public char[] Buffer => null;

		public long Length => 0L;

		public char[] Value => null;

		public static SqlChars Null => null;

		public SqlChars()
		{
		}

		public SqlChars(char[] buffer)
		{
		}

		public SqlChars(SqlString value)
		{
		}

		public void SetNull()
		{
		}

		internal bool FStream()
		{
			return false;
		}

		private void CopyStreamToBuffer()
		{
		}

		private void SetBuffer(char[] buffer)
		{
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader r)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
