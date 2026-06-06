using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaAny : XmlSchemaParticle
	{
		private string ns;

		private XmlSchemaContentProcessing processContents;

		private NamespaceList namespaceList;

		[XmlAttribute("namespace")]
		public string Namespace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("processContents")]
		[DefaultValue(XmlSchemaContentProcessing.None)]
		public XmlSchemaContentProcessing ProcessContents
		{
			set
			{
			}
		}

		[XmlIgnore]
		internal NamespaceList NamespaceList => null;

		[XmlIgnore]
		internal string ResolvedNamespace => null;

		[XmlIgnore]
		internal XmlSchemaContentProcessing ProcessContentsCorrect => default(XmlSchemaContentProcessing);

		internal override string NameString => null;

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
	}
}
