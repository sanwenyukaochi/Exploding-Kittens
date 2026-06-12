using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml.Schema;

namespace System.Xml
{
	[DefaultMember("Item")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlNode : ICloneable, IEnumerable
	{
		internal XmlNode parentNode;

		public abstract string Name { get; }

		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract XmlNodeType NodeType { get; }

		public virtual XmlNode ParentNode => null;

		public virtual XmlNodeList ChildNodes => null;

		public virtual XmlNode PreviousSibling => null;

		public virtual XmlNode NextSibling => null;

		public virtual XmlAttributeCollection Attributes => null;

		public virtual XmlDocument OwnerDocument => null;

		public virtual XmlNode FirstChild => null;

		public virtual XmlNode LastChild => null;

		internal virtual bool IsContainer => false;

		internal virtual XmlLinkedNode LastNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool HasChildNodes => false;

		public virtual string NamespaceURI => null;

		public virtual string Prefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string LocalName { get; }

		public virtual bool IsReadOnly => false;

		public virtual string InnerText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string InnerXml
		{
			set
			{
			}
		}

		public virtual IXmlSchemaInfo SchemaInfo => null;

		public virtual string BaseURI => null;

		internal XmlDocument Document => null;

		internal virtual XmlSpace XmlSpace => default(XmlSpace);

		internal virtual string XmlLang => null;

		internal virtual bool IsText => false;

		internal XmlNode()
		{
		}

		internal XmlNode(XmlDocument doc)
		{
		}

		internal bool AncestorNode(XmlNode node)
		{
			return false;
		}

		public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return null;
		}

		public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return null;
		}

		public virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			return null;
		}

		public virtual XmlNode PrependChild(XmlNode newChild)
		{
			return null;
		}

		public virtual XmlNode AppendChild(XmlNode newChild)
		{
			return null;
		}

		internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			return null;
		}

		internal virtual bool IsValidChildType(XmlNodeType type)
		{
			return false;
		}

		internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			return false;
		}

		public abstract XmlNode CloneNode(bool deep);

		internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
		}

		internal static bool HasReadOnlyParent(XmlNode n)
		{
			return false;
		}

		object ICloneable.Clone()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		private void AppendChildText(StringBuilder builder)
		{
		}

		public abstract void WriteTo(XmlWriter w);

		public abstract void WriteContentTo(XmlWriter w);

		public virtual void RemoveAll()
		{
		}

		public virtual string GetPrefixOfNamespace(string namespaceURI)
		{
			return null;
		}

		internal string GetPrefixOfNamespaceStrict(string namespaceURI)
		{
			return null;
		}

		internal virtual void SetParent(XmlNode node)
		{
		}

		internal virtual void SetParentForLoad(XmlNode node)
		{
		}

		internal static void SplitName(string name, out string prefix, out string localName)
		{
			prefix = null;
			localName = null;
		}

		internal virtual XmlNode FindChild(XmlNodeType type)
		{
			return null;
		}

		internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			return null;
		}

		internal virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
		}

		internal virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
		}

		internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
		}

		internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
		}
	}
}
