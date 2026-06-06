using System.Text;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlTextAttribute : Attribute
	{
		private string dataType;

		private Type type;

		public string DataType => null;

		public Type Type => null;

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
