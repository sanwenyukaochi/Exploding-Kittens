using System.ComponentModel;

namespace System.Data
{
	[DefaultProperty("ConstraintName")]
	[TypeConverter(typeof(ConstraintConverter))]
	public abstract class Constraint
	{
		private string _schemaName;

		private bool _inCollection;

		private DataSet _dataSet;

		internal string _name;

		internal PropertyCollection _extendedProperties;

		[DefaultValue(null)]
		public virtual string ConstraintName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string SchemaName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal virtual bool InCollection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public abstract DataTable Table { get; }

		[Browsable(false)]
		public PropertyCollection ExtendedProperties => null;

		[CLSCompliant(false)]
		protected virtual DataSet _DataSet => null;

		internal abstract bool ContainsColumn(DataColumn column);

		internal abstract bool CanEnableConstraint();

		internal abstract Constraint Clone(DataSet destination);

		internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

		internal void CheckConstraint()
		{
		}

		internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

		internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

		internal abstract void CheckConstraint(DataRow row, DataRowAction action);

		internal abstract void CheckState();

		protected void CheckStateForProperty()
		{
		}

		internal abstract bool IsConstraintViolated();

		public override string ToString()
		{
			return null;
		}
	}
}
