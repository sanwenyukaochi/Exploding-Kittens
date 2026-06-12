using System.IO;

namespace System.Xml
{
	public abstract class XmlWriter : IDisposable
	{
		private char[] writeNodeBuffer;

		public abstract WriteState WriteState { get; }

		public abstract void WriteStartDocument();

		public abstract void WriteStartDocument(bool standalone);

		public abstract void WriteEndDocument();

		public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

		public void WriteStartElement(string localName, string ns)
		{
		}

		public abstract void WriteStartElement(string prefix, string localName, string ns);

		public abstract void WriteEndElement();

		public abstract void WriteFullEndElement();

		public void WriteAttributeString(string localName, string ns, string value)
		{
		}

		public void WriteAttributeString(string localName, string value)
		{
		}

		public void WriteAttributeString(string prefix, string localName, string ns, string value)
		{
		}

		public abstract void WriteStartAttribute(string prefix, string localName, string ns);

		public abstract void WriteEndAttribute();

		public abstract void WriteCData(string text);

		public abstract void WriteComment(string text);

		public abstract void WriteProcessingInstruction(string name, string text);

		public abstract void WriteEntityRef(string name);

		public abstract void WriteCharEntity(char ch);

		public abstract void WriteWhitespace(string ws);

		public abstract void WriteString(string text);

		public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

		public abstract void WriteChars(char[] buffer, int index, int count);

		public abstract void WriteRaw(char[] buffer, int index, int count);

		public abstract void WriteRaw(string data);

		public abstract void WriteBase64(byte[] buffer, int index, int count);

		public virtual void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		public virtual void Close()
		{
		}

		public abstract void Flush();

		public abstract string LookupPrefix(string ns);

		public virtual void WriteValue(string value)
		{
		}

		public virtual void WriteAttributes(XmlReader reader, bool defattr)
		{
		}

		public virtual void WriteNode(XmlReader reader, bool defattr)
		{
		}

		public void WriteElementString(string localName, string ns, string value)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public static XmlWriter Create(Stream output, XmlWriterSettings settings)
		{
			return null;
		}

		public static XmlWriter Create(TextWriter output, XmlWriterSettings settings)
		{
			return null;
		}
	}
}
