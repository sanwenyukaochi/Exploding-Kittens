using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public abstract class XmlSchemaFacet : XmlSchemaAnnotated
	{
		private string value;

		private bool isFixed;

		private FacetType facetType;

		[XmlAttribute("value")]
		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("fixed")]
		[DefaultValue(false)]
		public virtual bool IsFixed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal FacetType FacetType
		{
			get
			{
				return default(FacetType);
			}
			set
			{
			}
		}
	}
}
