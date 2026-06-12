using System.Threading;

namespace System.ComponentModel
{
	public static class AsyncOperationManager
	{
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static SynchronizationContext SynchronizationContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static AsyncOperation CreateOperation(object userSuppliedState)
		{
			return null;
		}
	}
}
