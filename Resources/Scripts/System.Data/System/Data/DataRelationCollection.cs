using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Data
{
	[DefaultEvent("CollectionChanged")]
	[DefaultProperty("Table")]
	public abstract class DataRelationCollection : InternalDataCollectionBase
	{
		internal sealed class DataTableRelationCollection : DataRelationCollection
		{
			private readonly DataTable _table;

			private readonly ArrayList _relations;

			private readonly bool _fParentCollection;

			protected override ArrayList List => null;

			public override DataRelation this[int index] => null;

			public override DataRelation this[string name] => null;

			internal event CollectionChangeEventHandler RelationPropertyChanged
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			internal DataTableRelationCollection(DataTable table, bool fParentCollection)
			{
			}

			private void EnsureDataSet()
			{
			}

			protected override DataSet GetDataSet()
			{
				return null;
			}

			private void AddCache(DataRelation relation)
			{
			}

			protected override void AddCore(DataRelation relation)
			{
			}

			private void RemoveCache(DataRelation relation)
			{
			}

			protected override void RemoveCore(DataRelation relation)
			{
			}
		}

		internal sealed class DataSetRelationCollection : DataRelationCollection
		{
			private readonly DataSet _dataSet;

			private readonly ArrayList _relations;

			private DataRelation[] _delayLoadingRelations;

			protected override ArrayList List => null;

			public override DataRelation this[int index] => null;

			public override DataRelation this[string name] => null;

			internal DataSetRelationCollection(DataSet dataSet)
			{
			}

			public override void Clear()
			{
			}

			protected override DataSet GetDataSet()
			{
				return null;
			}

			protected override void AddCore(DataRelation relation)
			{
			}

			protected override void RemoveCore(DataRelation relation)
			{
			}

			internal void FinishInitRelations()
			{
			}
		}

		private DataRelation _inTransition;

		private int _defaultNameIndex;

		private CollectionChangeEventHandler _onCollectionChangedDelegate;

		private CollectionChangeEventHandler _onCollectionChangingDelegate;

		private static int s_objectTypeCount;

		private readonly int _objectID;

		internal int ObjectID => 0;

		public abstract DataRelation this[int index] { get; }

		public abstract DataRelation this[string name] { get; }

		public event CollectionChangeEventHandler CollectionChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Add(DataRelation relation)
		{
		}

		protected virtual void AddCore(DataRelation relation)
		{
		}

		internal string AssignName()
		{
			return null;
		}

		public virtual void Clear()
		{
		}

		public virtual bool Contains(string name)
		{
			return false;
		}

		internal int InternalIndexOf(string name)
		{
			return 0;
		}

		protected abstract DataSet GetDataSet();

		private string MakeName(int index)
		{
			return null;
		}

		protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
		{
		}

		protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent)
		{
		}

		internal void RegisterName(string name)
		{
		}

		public void Remove(DataRelation relation)
		{
		}

		public void RemoveAt(int index)
		{
		}

		protected virtual void RemoveCore(DataRelation relation)
		{
		}

		internal void UnregisterName(string name)
		{
		}
	}
}
