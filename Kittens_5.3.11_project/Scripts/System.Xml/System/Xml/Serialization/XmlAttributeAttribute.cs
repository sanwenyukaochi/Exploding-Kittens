using System.Text;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlAttributeAttribute : Attribute
	{
		private string attributeName;

		private string dataType;

		private Type type;

		private XmlSchemaForm form;

		private string ns;

		public string AttributeName => null;

		public string DataType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlSchemaForm Form => default(XmlSchemaForm);

		public string Namespace => null;

		public XmlAttributeAttribute(string attributeName)
		{
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
