using System.ComponentModel;

namespace System.Data
{
	[DefaultProperty("ConstraintName")]
	public class UniqueConstraint : Constraint
	{
		private DataKey _key;

		private Index _constraintIndex;

		internal bool _bPrimaryKey;

		internal string _constraintName;

		internal string[] _columnNames;

		internal string[] ColumnNames => null;

		internal Index ConstraintIndex => null;

		[ReadOnly(true)]
		public virtual DataColumn[] Columns => null;

		internal DataColumn[] ColumnsReference => null;

		public bool IsPrimaryKey => false;

		internal override bool InCollection
		{
			set
			{
			}
		}

		internal DataKey Key => default(DataKey);

		[ReadOnly(true)]
		public override DataTable Table => null;

		public UniqueConstraint(DataColumn column)
		{
		}

		public UniqueConstraint(string name, DataColumn[] columns)
		{
		}

		public UniqueConstraint(DataColumn[] columns)
		{
		}

		[Browsable(false)]
		public UniqueConstraint(string name, string[] columnNames, bool isPrimaryKey)
		{
		}

		public UniqueConstraint(string name, DataColumn[] columns, bool isPrimaryKey)
		{
		}

		internal void ConstraintIndexClear()
		{
		}

		internal void ConstraintIndexInitialize()
		{
		}

		internal override void CheckState()
		{
		}

		private void NonVirtualCheckState()
		{
		}

		internal override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
		}

		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			return false;
		}

		internal override bool CanEnableConstraint()
		{
			return false;
		}

		internal override bool IsConstraintViolated()
		{
			return false;
		}

		internal override void CheckConstraint(DataRow row, DataRowAction action)
		{
		}

		internal override bool ContainsColumn(DataColumn column)
		{
			return false;
		}

		internal override Constraint Clone(DataSet destination)
		{
			return null;
		}

		internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup)
		{
			return null;
		}

		internal UniqueConstraint Clone(DataTable table)
		{
			return null;
		}

		private void Create(string constraintName, DataColumn[] columns)
		{
		}

		public override bool Equals(object key2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
