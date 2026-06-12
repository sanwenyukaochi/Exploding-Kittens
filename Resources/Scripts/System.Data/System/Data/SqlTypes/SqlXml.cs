using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public sealed class SqlXml : INullable, IXmlSerializable
	{
		private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate;

		private static readonly XmlReaderSettings s_defaultXmlReaderSettings;

		private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput;

		private static MethodInfo s_createSqlReaderMethodInfo;

		private MethodInfo _createSqlReaderMethodInfo;

		private bool _fNotNull;

		private Stream _stream;

		private bool _firstCreateReader;

		private static MethodInfo CreateSqlReaderMethodInfo => null;

		public bool IsNull => false;

		public XmlReader CreateReader()
		{
			return null;
		}

		internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = false, bool throwTargetInvocationExceptions = false)
		{
			return null;
		}

		private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate()
		{
			return null;
		}

		private void SetNull()
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
	}
}
