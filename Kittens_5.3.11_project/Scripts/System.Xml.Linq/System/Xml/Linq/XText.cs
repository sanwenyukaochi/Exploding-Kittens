using System.Text;

namespace System.Xml.Linq
{
	public class XText : XNode
	{
		internal string text;

		public override XmlNodeType NodeType => default(XmlNodeType);

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

		public XText(string value)
		{
		}

		public XText(XText other)
		{
		}

		public override void WriteTo(XmlWriter writer)
		{
		}

		internal override void AppendText(StringBuilder sb)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}
	}
}
