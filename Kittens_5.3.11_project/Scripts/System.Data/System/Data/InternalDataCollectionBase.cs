using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace System.Data
{
	public class InternalDataCollectionBase : ICollection, IEnumerable
	{
		internal static readonly CollectionChangeEventArgs s_refreshEventArgs;

		[Browsable(false)]
		public virtual int Count => 0;

		[Browsable(false)]
		public bool IsSynchronized => false;

		[Browsable(false)]
		public object SyncRoot => null;

		protected virtual ArrayList List => null;

		public virtual void CopyTo(Array ar, int index)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale)
		{
			return 0;
		}
	}
}
