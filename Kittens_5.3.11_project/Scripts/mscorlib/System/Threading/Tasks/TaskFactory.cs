using System.Collections.Generic;

namespace System.Threading.Tasks
{
	public class TaskFactory<TResult>
	{
		private sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			internal static readonly AsyncCallback s_completeFromAsyncResult;

			private TInstance m_thisRef;

			private Func<TInstance, IAsyncResult, TResult> m_endMethod;

			internal FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
			{
			}

			internal static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
			}

			internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
			}
		}

		private CancellationToken m_defaultCancellationToken;

		private TaskScheduler m_defaultScheduler;

		private TaskCreationOptions m_defaultCreationOptions;

		private TaskContinuationOptions m_defaultContinuationOptions;

		public TaskFactory()
		{
		}

		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
		}

		private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
		}

		public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state)
		{
			return null;
		}

		internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state)
		{
			return null;
		}

		internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			return null;
		}
	}
	public class TaskFactory
	{
		internal sealed class CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction
		{
			private IList<Task> _tasks;

			public bool InvokeMayRunArbitraryCode => false;

			public CompleteOnInvokePromise(IList<Task> tasks)
			{
			}

			public void Invoke(Task completingTask)
			{
			}
		}

		private readonly CancellationToken m_defaultCancellationToken;

		private readonly TaskScheduler m_defaultScheduler;

		private readonly TaskCreationOptions m_defaultCreationOptions;

		private readonly TaskContinuationOptions m_defaultContinuationOptions;

		public TaskFactory()
		{
		}

		public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
		}

		internal static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
		}

		public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state)
		{
			return null;
		}

		public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state)
		{
			return null;
		}

		public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
		{
			return null;
		}

		internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
		}

		internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
		{
			return null;
		}

		internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
		}
	}
}
