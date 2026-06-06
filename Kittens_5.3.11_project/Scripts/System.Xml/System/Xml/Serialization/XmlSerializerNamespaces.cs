using System.Collections;

namespace System.Xml.Serialization
{
	public class XmlSerializerNamespaces
	{
		private Hashtable namespaces;

		public int Count => 0;

		internal ArrayList NamespaceList => null;

		internal Hashtable Namespaces
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Add(string prefix, string ns)
		{
		}

		internal void AddInternal(string prefix, string ns)
		{
		}

		public XmlQualifiedName[] ToArray()
		{
			return null;
		}
	}
}
