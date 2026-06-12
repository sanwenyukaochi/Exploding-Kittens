using System.Collections;
using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		internal enum Stamp
		{
			Check = 0,
			Set = 1,
			SetToUnused = 2,
			SetToMaxUsed = 3
		}

		private class CookieCollectionEnumerator : IEnumerator
		{
			private CookieCollection m_cookies;

			private int m_count;

			private int m_index;

			private int m_version;

			object IEnumerator.Current => null;

			internal CookieCollectionEnumerator(CookieCollection cookies)
			{
			}

			bool IEnumerator.MoveNext()
			{
				return false;
			}

			void IEnumerator.Reset()
			{
			}
		}

		internal int m_version;

		private ArrayList m_list;

		private DateTime m_TimeStamp;

		private bool m_has_other_versions;

		[OptionalField]
		private bool m_IsReadOnly;

		public Cookie this[int index] => null;

		public int Count => 0;

		public bool IsSynchronized => false;

		public object SyncRoot => null;

		internal bool IsOtherVersionSeen => false;

		public void Add(Cookie cookie)
		{
		}

		public void Add(CookieCollection cookies)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		internal DateTime TimeStamp(Stamp how)
		{
			return default(DateTime);
		}

		internal int InternalAdd(Cookie cookie, bool isStrict)
		{
			return 0;
		}

		internal int IndexOf(Cookie cookie)
		{
			return 0;
		}

		internal void RemoveAt(int idx)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
