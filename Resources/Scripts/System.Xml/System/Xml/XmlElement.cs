using System.Xml.Schema;

namespace System.Xml
{
	public class XmlElement : XmlLinkedNode
	{
		private XmlName name;

		private XmlAttributeCollection attributes;

		private XmlLinkedNode lastChild;

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

		public override XmlNode ParentNode => null;

		public override XmlDocument OwnerDocument => null;

		internal override bool IsContainer => false;

		public bool IsEmpty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public override XmlAttributeCollection Attributes => null;

		public virtual bool HasAttributes => false;

		public override IXmlSchemaInfo SchemaInfo => null;

		public override string InnerXml
		{
			set
			{
			}
		}

		public override string InnerText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override XmlNode NextSibling => null;

		internal XmlElement(XmlName name, bool empty, XmlDocument doc)
			: base(null)
		{
		}

		protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc)
			: base(null)
		{
		}

		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}

		internal override bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		public virtual string GetAttribute(string name)
		{
			return null;
		}

		public virtual void SetAttribute(string name, string value)
		{
		}

		public virtual XmlAttribute GetAttributeNode(string name)
		{
			return null;
		}

		public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			return null;
		}

		public virtual string GetAttribute(string localName, string namespaceURI)
		{
			return null;
		}

		public virtual string SetAttribute(string localName, string namespaceURI, string value)
		{
			return null;
		}

		public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI)
		{
			return null;
		}

		public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI)
		{
			return null;
		}

		public virtual bool HasAttribute(string name)
		{
			return false;
		}

		public override void WriteTo(XmlWriter w)
		{
		}

		private static void WriteElementTo(XmlWriter writer, XmlElement e)
		{
		}

		private void WriteStartElement(XmlWriter w)
		{
		}

		public override void WriteContentTo(XmlWriter w)
		{
		}

		public virtual void RemoveAllAttributes()
		{
		}

		public override void RemoveAll()
		{
		}

		internal void RemoveAllChildren()
		{
		}

		internal override void SetParent(XmlNode node)
		{
		}
	}
}
