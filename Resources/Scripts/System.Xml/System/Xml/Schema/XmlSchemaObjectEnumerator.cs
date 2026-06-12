using System.Collections;

namespace System.Xml.Schema
{
	public class XmlSchemaObjectEnumerator : IEnumerator
	{
		private IEnumerator enumerator;

		public XmlSchemaObject Current => null;

		object IEnumerator.Current => null;

		internal XmlSchemaObjectEnumerator(IEnumerator enumerator)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}
	}
}
