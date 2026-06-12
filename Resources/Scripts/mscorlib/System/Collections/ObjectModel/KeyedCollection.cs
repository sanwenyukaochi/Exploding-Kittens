using System.Collections.Generic;
using System.Diagnostics;

namespace System.Collections.ObjectModel
{
	[Serializable]
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		private readonly IEqualityComparer<TKey> comparer;

		private Dictionary<TKey, TItem> dict;

		private int keyCount;

		private readonly int threshold;

		private new List<TItem> Items => null;

		public TItem this[TKey key] => default(TItem);

		protected IDictionary<TKey, TItem> Dictionary => null;

		protected KeyedCollection()
		{
		}

		protected KeyedCollection(IEqualityComparer<TKey> comparer)
		{
		}

		protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
		{
		}

		public bool Contains(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TItem item)
		{
			item = default(TItem);
			return false;
		}

		protected override void ClearItems()
		{
		}

		protected abstract TKey GetKeyForItem(TItem item);

		protected override void InsertItem(int index, TItem item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		protected override void SetItem(int index, TItem item)
		{
		}

		private void AddKey(TKey key, TItem item)
		{
		}

		private void CreateDictionary()
		{
		}

		private void RemoveKey(TKey key)
		{
		}
	}
}
