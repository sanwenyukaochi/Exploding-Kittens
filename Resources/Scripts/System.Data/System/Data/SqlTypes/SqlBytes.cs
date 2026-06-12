using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[DefaultMember("Item")]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable
	{
		internal byte[] _rgbBuf;

		private long _lCurLen;

		internal Stream _stream;

		private SqlBytesCharsState _state;

		private byte[] _rgbWorkBuf;

		public bool IsNull => false;

		public byte[] Buffer => null;

		public long Length => 0L;

		public byte[] Value => null;

		public static SqlBytes Null => null;

		public SqlBytes()
		{
		}

		public SqlBytes(byte[] buffer)
		{
		}

		public SqlBytes(SqlBinary value)
		{
		}

		public void SetNull()
		{
		}

		private void CopyStreamToBuffer()
		{
		}

		internal bool FStream()
		{
			return false;
		}

		private void SetBuffer(byte[] buffer)
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
