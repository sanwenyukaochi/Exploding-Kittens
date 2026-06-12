using System.Diagnostics;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	public struct AsyncTaskMethodBuilder
	{
		private static readonly Task<VoidTaskResult> s_cachedCompleted;

		private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;

		public Task Task => null;

		public static AsyncTaskMethodBuilder Create()
		{
			return default(AsyncTaskMethodBuilder);
		}

		[DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		public void SetResult()
		{
		}

		public void SetException(Exception exception)
		{
		}
	}
	public struct AsyncTaskMethodBuilder<TResult>
	{
		internal static readonly Task<TResult> s_defaultResultTask;

		private AsyncMethodBuilderCore m_coreState;

		private Task<TResult> m_task;

		public Task<TResult> Task => null;

		public static AsyncTaskMethodBuilder<TResult> Create()
		{
			return default(AsyncTaskMethodBuilder<TResult>);
		}

		[DebuggerStepThrough]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		public void SetResult(TResult result)
		{
		}

		internal void SetResult(Task<TResult> completedTask)
		{
		}

		public void SetException(Exception exception)
		{
		}

		internal static Task<TResult> GetTaskForResult(TResult result)
		{
			return null;
		}
	}
}
