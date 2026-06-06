using System.ComponentModel;

namespace System.Data
{
	[DefaultProperty("ConstraintName")]
	public class ForeignKeyConstraint : Constraint
	{
		internal Rule _deleteRule;

		internal Rule _updateRule;

		internal AcceptRejectRule _acceptRejectRule;

		private DataKey _childKey;

		private DataKey _parentKey;

		internal string _constraintName;

		internal string[] _parentColumnNames;

		internal string[] _childColumnNames;

		internal string _parentTableName;

		internal string _parentTableNamespace;

		internal DataKey ChildKey => default(DataKey);

		[ReadOnly(true)]
		public virtual DataColumn[] Columns => null;

		[ReadOnly(true)]
		public override DataTable Table => null;

		internal string[] ParentColumnNames => null;

		internal string[] ChildColumnNames => null;

		[DefaultValue(AcceptRejectRule.None)]
		public virtual AcceptRejectRule AcceptRejectRule
		{
			get
			{
				return default(AcceptRejectRule);
			}
			set
			{
			}
		}

		[DefaultValue(Rule.Cascade)]
		public virtual Rule DeleteRule
		{
			get
			{
				return default(Rule);
			}
			set
			{
			}
		}

		[ReadOnly(true)]
		public virtual DataColumn[] RelatedColumns => null;

		internal DataColumn[] RelatedColumnsReference => null;

		internal DataKey ParentKey => default(DataKey);

		[ReadOnly(true)]
		public virtual DataTable RelatedTable => null;

		[DefaultValue(Rule.Cascade)]
		public virtual Rule UpdateRule
		{
			get
			{
				return default(Rule);
			}
			set
			{
			}
		}

		public ForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		public ForeignKeyConstraint(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		[Browsable(false)]
		public ForeignKeyConstraint(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule)
		{
		}

		internal override void CheckCanAddToCollection(ConstraintCollection constraints)
		{
		}

		internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException)
		{
			return false;
		}

		internal bool IsKeyNull(object[] values)
		{
			return false;
		}

		internal override bool IsConstraintViolated()
		{
			return false;
		}

		internal override bool CanEnableConstraint()
		{
			return false;
		}

		internal void CascadeCommit(DataRow row)
		{
		}

		internal void CascadeDelete(DataRow row)
		{
		}

		internal void CascadeRollback(DataRow row)
		{
		}

		internal void CascadeUpdate(DataRow row)
		{
		}

		internal void CheckCanClearParentTable(DataTable table)
		{
		}

		internal void CheckCanRemoveParentRow(DataRow row)
		{
		}

		internal void CheckCascade(DataRow row, DataRowAction action)
		{
		}

		internal override void CheckConstraint(DataRow childRow, DataRowAction action)
		{
		}

		private void NonVirtualCheckState()
		{
		}

		internal override void CheckState()
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

		internal ForeignKeyConstraint Clone(DataTable destination)
		{
			return null;
		}

		private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns)
		{
		}

		public override bool Equals(object key)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal DataRelation FindParentRelation()
		{
			return null;
		}
	}
}
