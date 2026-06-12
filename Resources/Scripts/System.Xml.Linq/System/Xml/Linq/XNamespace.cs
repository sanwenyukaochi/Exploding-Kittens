namespace System.Xml.Linq
{
	public sealed class XNamespace
	{
		private static XHashtable<WeakReference> s_namespaces;

		private static WeakReference s_refNone;

		private static WeakReference s_refXml;

		private static WeakReference s_refXmlns;

		private string _namespaceName;

		private int _hashCode;

		private XHashtable<XName> _names;

		public string NamespaceName => null;

		public static XNamespace None => null;

		public static XNamespace Xml => null;

		public static XNamespace Xmlns => null;

		internal XNamespace(string namespaceName)
		{
		}

		public XName GetName(string localName)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static XNamespace Get(string namespaceName)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static implicit operator XNamespace(string namespaceName)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(XNamespace left, XNamespace right)
		{
			return false;
		}

		public static bool operator !=(XNamespace left, XNamespace right)
		{
			return false;
		}

		internal XName GetName(string localName, int index, int count)
		{
			return null;
		}

		internal static XNamespace Get(string namespaceName, int index, int count)
		{
			return null;
		}

		private static string ExtractLocalName(XName n)
		{
			return null;
		}

		private static string ExtractNamespace(WeakReference r)
		{
			return null;
		}

		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName)
		{
			return null;
		}
	}
}
