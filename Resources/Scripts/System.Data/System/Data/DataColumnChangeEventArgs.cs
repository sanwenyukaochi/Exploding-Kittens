using System.Runtime.CompilerServices;

namespace System.Data
{
	public class DataColumnChangeEventArgs : EventArgs
	{
		private DataColumn _column;

		[CompilerGenerated]
		private readonly DataRow _003CRow_003Ek__BackingField;

		public object ProposedValue { get; set; }

		internal DataColumnChangeEventArgs(DataRow row)
		{
		}

		public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value)
		{
		}

		internal void InitializeColumnChangeEvent(DataColumn column, object value)
		{
		}
	}
}
