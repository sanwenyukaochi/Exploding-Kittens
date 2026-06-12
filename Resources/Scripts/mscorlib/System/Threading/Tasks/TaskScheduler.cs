using System.Diagnostics;

namespace System.Threading.Tasks
{
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
	[DebuggerDisplay("Id={Id}")]
	public abstract class TaskScheduler
	{
		internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
		{
		}

		private static readonly TaskScheduler s_defaultTaskScheduler;

		internal static int s_taskSchedulerIdCounter;

		private int m_taskSchedulerId;

		private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException;

		private static readonly Lock _unobservedTaskExceptionLockObject;

		internal virtual bool RequiresAtomicStartTransition => false;

		public static TaskScheduler Default => null;

		public static TaskScheduler Current => null;

		internal static TaskScheduler InternalCurrent => null;

		public int Id => 0;

		protected internal abstract void QueueTask(Task task);

		protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

		internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
		{
			return false;
		}

		protected internal virtual bool TryDequeue(Task task)
		{
			return false;
		}

		internal virtual void NotifyWorkItemProgress()
		{
		}

		public static TaskScheduler FromCurrentSynchronizationContext()
		{
			return null;
		}

		protected bool TryExecuteTask(Task task)
		{
			return false;
		}

		internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea)
		{
		}
	}
}
