namespace System.Threading.Tasks
{
	public class TaskCompletionSource<TResult>
	{
		private readonly Task<TResult> _task;

		public Task<TResult> Task => null;

		public TaskCompletionSource()
		{
		}

		public TaskCompletionSource(TaskCreationOptions creationOptions)
		{
		}

		public TaskCompletionSource(object state)
		{
		}

		public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
		{
		}

		private void SpinUntilCompleted()
		{
		}

		public bool TrySetException(Exception exception)
		{
			return false;
		}

		public bool TrySetResult(TResult result)
		{
			return false;
		}
	}
}
