using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAnyAttribute : XmlSchemaAnnotated
	{
		private string ns;

		private XmlSchemaContentProcessing processContents;

		private NamespaceList namespaceList;

		[XmlAttribute("namespace")]
		public string Namespace
		{
			set
			{
			}
		}

		[DefaultValue(XmlSchemaContentProcessing.None)]
		[XmlAttribute("processContents")]
		public XmlSchemaContentProcessing ProcessContents
		{
			get
			{
				return default(XmlSchemaContentProcessing);
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal NamespaceList NamespaceList => null;

		[XmlIgnore]
		internal XmlSchemaContentProcessing ProcessContentsCorrect => default(XmlSchemaContentProcessing);

		internal void BuildNamespaceList(string targetNamespace)
		{
		}

		internal void BuildNamespaceListV1Compat(string targetNamespace)
		{
		}

		internal bool Allows(XmlQualifiedName qname)
		{
			return false;
		}

		internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super)
		{
			return false;
		}

		internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
		{
			return null;
		}

		internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat)
		{
			return null;
		}
	}
}
