using System.Text;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Field)]
	public class XmlEnumAttribute : Attribute
	{
		private string name;

		public string Name => null;

		public XmlEnumAttribute(string name)
		{
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
