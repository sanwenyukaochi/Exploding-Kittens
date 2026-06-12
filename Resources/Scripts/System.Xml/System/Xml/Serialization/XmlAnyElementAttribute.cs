using System.Text;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlAnyElementAttribute : Attribute
	{
		private string elementName;

		private string ns;

		private int order;

		public string Name => null;

		public string Namespace => null;

		public int Order => 0;

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
