using System.Text;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
	public class XmlArrayAttribute : Attribute
	{
		private string elementName;

		private XmlSchemaForm form;

		private bool isNullable;

		private string ns;

		private int order;

		public string ElementName => null;

		public XmlSchemaForm Form => default(XmlSchemaForm);

		public bool IsNullable => false;

		public string Namespace => null;

		public int Order => 0;

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
