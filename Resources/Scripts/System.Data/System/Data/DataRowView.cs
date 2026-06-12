using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Data
{
	[DefaultMember("Item")]
	public class DataRowView : ICustomTypeDescriptor, IEditableObject, IDataErrorInfo, INotifyPropertyChanged
	{
		private readonly DataView _dataView;

		private readonly DataRow _row;

		private bool _delayBeginEdit;

		private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection;

		public DataView DataView => null;

		string IDataErrorInfo.this[string colName] => null;

		string IDataErrorInfo.Error => null;

		private DataRowVersion RowVersionDefault => default(DataRowVersion);

		public DataRow Row => null;

		public bool IsNew => false;

		public event PropertyChangedEventHandler PropertyChanged
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

		internal DataRowView(DataView dataView, DataRow row)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal int GetRecord()
		{
			return 0;
		}

		internal bool HasRecord()
		{
			return false;
		}

		internal object GetColumnValue(DataColumn column)
		{
			return null;
		}

		internal void SetColumnValue(DataColumn column, object value)
		{
		}

		public DataView CreateChildView(DataRelation relation, bool followParent)
		{
			return null;
		}

		public DataView CreateChildView(DataRelation relation)
		{
			return null;
		}

		public void BeginEdit()
		{
		}

		public void CancelEdit()
		{
		}

		public void EndEdit()
		{
		}

		internal void RaisePropertyChangedEvent(string propName)
		{
		}

		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		string ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return null;
		}

		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return null;
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return null;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return null;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return null;
		}

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}
}
