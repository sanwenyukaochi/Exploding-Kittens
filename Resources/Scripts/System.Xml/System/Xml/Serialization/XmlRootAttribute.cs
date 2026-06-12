using System.Text;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.ReturnValue)]
	public class XmlRootAttribute : Attribute
	{
		private string dataType;

		private string elementName;

		private bool isNullable;

		private string ns;

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

		public string ElementName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsNullable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public XmlRootAttribute()
		{
		}

		public XmlRootAttribute(string elementName)
		{
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
