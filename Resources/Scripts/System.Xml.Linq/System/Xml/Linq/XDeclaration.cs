namespace System.Xml.Linq
{
	public class XDeclaration
	{
		private string _version;

		private string _encoding;

		private string _standalone;

		public string Encoding => null;

		public string Standalone => null;

		public string Version => null;

		public XDeclaration(string version, string encoding, string standalone)
		{
		}

		public XDeclaration(XDeclaration other)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
