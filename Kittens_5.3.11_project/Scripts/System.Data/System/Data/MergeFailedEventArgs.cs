using System.Runtime.CompilerServices;

namespace System.Data
{
	public class MergeFailedEventArgs : EventArgs
	{
		[CompilerGenerated]
		private readonly DataTable _003CTable_003Ek__BackingField;

		public string Conflict { get; }

		public MergeFailedEventArgs(DataTable table, string conflict)
		{
		}
	}
}
