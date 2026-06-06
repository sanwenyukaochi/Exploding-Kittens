using System.Xml.Schema;

namespace System.Xml
{
	public class XmlAttribute : XmlNode
	{
		private XmlName name;

		private XmlLinkedNode lastChild;

		internal int LocalNameHash => 0;

		internal XmlName XmlName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override XmlNode ParentNode => null;

		public override string Name => null;

		public override string LocalName => null;

		public override string NamespaceURI => null;

		public override string Prefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override XmlNodeType NodeType => default(XmlNodeType);

		public override XmlDocument OwnerDocument => null;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override IXmlSchemaInfo SchemaInfo => null;

		public override string InnerText
		{
			set
			{
			}
		}

		internal override bool IsContainer => false;

		internal override XmlLinkedNode LastNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool Specified => false;

		public virtual XmlElement OwnerElement => null;

		public override string InnerXml
		{
			set
			{
			}
		}

		public override string BaseURI => null;

		internal override XmlSpace XmlSpace => default(XmlSpace);

		internal override string XmlLang => null;

		internal XmlAttribute(XmlName name, XmlDocument doc)
		{
		}

		protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
		{
		}

		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		internal bool PrepareOwnerElementInElementIdAttrMap()
		{
			return false;
		}

		internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
		{
		}

		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}

		internal override bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return null;
		}

		public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return null;
		}

		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			return null;
		}

		public override XmlNode PrependChild(XmlNode newChild)
		{
			return null;
		}

		public override XmlNode AppendChild(XmlNode newChild)
		{
			return null;
		}

		public override void WriteTo(XmlWriter w)
		{
		}

		public override void WriteContentTo(XmlWriter w)
		{
		}

		internal override void SetParent(XmlNode node)
		{
		}
	}
}
