using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	public struct AsyncVoidMethodBuilder
	{
		private SynchronizationContext m_synchronizationContext;

		private AsyncMethodBuilderCore m_coreState;

		private Task m_task;

		internal Task Task => null;

		public static AsyncVoidMethodBuilder Create()
		{
			return default(AsyncVoidMethodBuilder);
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

		private void NotifySynchronizationContextOfCompletion()
		{
		}
	}
}
