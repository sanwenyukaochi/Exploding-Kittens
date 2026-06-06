using System.Threading;

namespace System.ComponentModel
{
	public sealed class AsyncOperation
	{
		private readonly SynchronizationContext _syncContext;

		private readonly object _userSuppliedState;

		private bool _alreadyCompleted;

		public object UserSuppliedState => null;

		public SynchronizationContext SynchronizationContext => null;

		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
		}

		~AsyncOperation()
		{
		}

		public void Post(SendOrPostCallback d, object arg)
		{
		}

		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
		}

		public void OperationCompleted()
		{
		}

		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
		}

		private void OperationCompletedCore()
		{
		}

		private void VerifyNotCompleted()
		{
		}

		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
		}

		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			return null;
		}

		internal AsyncOperation()
		{
		}
	}
}
