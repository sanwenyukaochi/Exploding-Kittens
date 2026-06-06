namespace System.Xml
{
	[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
	public class XmlValidatingReader : XmlReader
	{
		private XmlValidatingReaderImpl impl;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override string LocalName => null;

		public override string NamespaceURI => null;

		public override string Prefix => null;

		public override string Value => null;

		public override int Depth => 0;

		public override string BaseURI => null;

		public override bool IsEmptyElement => false;

		public override int AttributeCount => 0;

		public override bool EOF => false;

		public override ReadState ReadState => default(ReadState);

		public override XmlNameTable NameTable => null;

		public bool Namespaces => false;

		public override string GetAttribute(string name)
		{
			return null;
		}

		public override string GetAttribute(string localName, string namespaceURI)
		{
			return null;
		}

		public override string GetAttribute(int i)
		{
			return null;
		}

		public override bool MoveToAttribute(string name)
		{
			return false;
		}

		public override bool MoveToFirstAttribute()
		{
			return false;
		}

		public override bool MoveToNextAttribute()
		{
			return false;
		}

		public override bool MoveToElement()
		{
			return false;
		}

		public override bool ReadAttributeValue()
		{
			return false;
		}

		public override bool Read()
		{
			return false;
		}

		public override string LookupNamespace(string prefix)
		{
			return null;
		}

		public override void ResolveEntity()
		{
		}
	}
}
