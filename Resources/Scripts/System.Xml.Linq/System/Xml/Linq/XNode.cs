using System.Text;

namespace System.Xml.Linq
{
	public abstract class XNode : XObject
	{
		internal XNode next;

		internal XNode()
		{
		}

		public void Remove()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public abstract void WriteTo(XmlWriter writer);

		internal virtual void AppendText(StringBuilder sb)
		{
		}

		internal abstract XNode CloneNode();

		private string GetXmlString(SaveOptions o)
		{
			return null;
		}
	}
}
