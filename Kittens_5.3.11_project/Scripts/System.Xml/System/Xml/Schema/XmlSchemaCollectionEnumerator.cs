using System.Collections;

namespace System.Xml.Schema
{
	public sealed class XmlSchemaCollectionEnumerator : IEnumerator
	{
		private IDictionaryEnumerator enumerator;

		object IEnumerator.Current => null;

		public XmlSchema Current => null;

		internal XmlSchemaCollectionNode CurrentNode => null;

		internal XmlSchemaCollectionEnumerator(Hashtable collection)
		{
		}

		void IEnumerator.Reset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		public bool MoveNext()
		{
			return false;
		}
	}
}
