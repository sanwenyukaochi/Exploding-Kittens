namespace System.Xml
{
	[Serializable]
	public class XmlQualifiedName
	{
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);

		private static HashCodeOfStringDelegate hashCodeDelegate;

		private string name;

		private string ns;

		[NonSerialized]
		private int hash;

		public static readonly XmlQualifiedName Empty;

		public string Namespace => null;

		public string Name => null;

		public bool IsEmpty => false;

		public XmlQualifiedName()
		{
		}

		public XmlQualifiedName(string name)
		{
		}

		public XmlQualifiedName(string name, string ns)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			return false;
		}

		public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			return false;
		}

		public static string ToString(string name, string ns)
		{
			return null;
		}

		private static HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			return null;
		}

		private static bool IsRandomizedHashingDisabled()
		{
			return false;
		}

		private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			return 0;
		}

		internal void Init(string name, string ns)
		{
		}

		internal void SetNamespace(string ns)
		{
		}

		internal void Verify()
		{
		}

		internal void Atomize(XmlNameTable nameTable)
		{
		}

		internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			prefix = null;
			return null;
		}

		internal XmlQualifiedName Clone()
		{
			return null;
		}
	}
}
