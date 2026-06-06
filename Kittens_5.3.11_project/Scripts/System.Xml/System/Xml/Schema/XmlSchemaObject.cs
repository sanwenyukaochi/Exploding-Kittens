using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public abstract class XmlSchemaObject
	{
		private int lineNum;

		private int linePos;

		private string sourceUri;

		private XmlSerializerNamespaces namespaces;

		private XmlSchemaObject parent;

		private bool isProcessing;

		[XmlIgnore]
		public int LineNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public int LinePosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public string SourceUri
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlSchemaObject Parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlNamespaceDeclarations]
		public XmlSerializerNamespaces Namespaces
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal virtual string IdAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal virtual string NameAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal bool IsProcessing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal virtual void OnAdd(XmlSchemaObjectCollection container, object item)
		{
		}

		internal virtual void OnRemove(XmlSchemaObjectCollection container, object item)
		{
		}

		internal virtual void OnClear(XmlSchemaObjectCollection container)
		{
		}

		internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes)
		{
		}

		internal virtual void AddAnnotation(XmlSchemaAnnotation annotation)
		{
		}

		internal virtual XmlSchemaObject Clone()
		{
			return null;
		}
	}
}
