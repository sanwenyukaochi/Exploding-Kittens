using System.Collections;
using System.Collections.Generic;

namespace System.Xml
{
	public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
	{
		private struct NamespaceDeclaration
		{
			public string prefix;

			public string uri;

			public int scopeId;

			public int previousNsIndex;

			public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
			}
		}

		private NamespaceDeclaration[] nsdecls;

		private int lastDecl;

		private XmlNameTable nameTable;

		private int scopeId;

		private Dictionary<string, int> hashTable;

		private bool useHashtable;

		private string xml;

		private string xmlNs;

		public virtual XmlNameTable NameTable => null;

		public virtual string DefaultNamespace => null;

		internal XmlNamespaceManager()
		{
		}

		public XmlNamespaceManager(XmlNameTable nameTable)
		{
		}

		public virtual void PushScope()
		{
		}

		public virtual bool PopScope()
		{
			return false;
		}

		public virtual void AddNamespace(string prefix, string uri)
		{
		}

		public virtual void RemoveNamespace(string prefix, string uri)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		public virtual string LookupNamespace(string prefix)
		{
			return null;
		}

		private int LookupNamespaceDecl(string prefix)
		{
			return 0;
		}

		public virtual string LookupPrefix(string uri)
		{
			return null;
		}
	}
}
