using System.Collections;

namespace System.ComponentModel
{
	public class ComponentCollection : ReadOnlyCollectionBase
	{
		public virtual IComponent this[string name] => null;

		public virtual IComponent this[int index] => null;

		public ComponentCollection(IComponent[] components)
		{
		}

		public void CopyTo(IComponent[] array, int index)
		{
		}
	}
}
