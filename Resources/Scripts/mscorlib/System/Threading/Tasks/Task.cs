using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace System.Threading.Tasks
{
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	public class Task<TResult> : Task
	{
		internal TResult m_result;

		private static TaskFactory<TResult> s_defaultFactory;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result => default(TResult);

		internal TResult ResultOnSuccess => default(TResult);

		public new static TaskFactory<TResult> Factory => null;

		internal Task()
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(object state, TaskCreationOptions options)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(TResult result)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: base(canceled: false, default(TaskCreationOptions), default(CancellationToken))
		{
		}

		internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return null;
		}

		internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			return null;
		}

		internal bool TrySetResult(TResult result)
		{
			return false;
		}

		internal void DangerousSetResult(TResult result)
		{
		}

		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			return default(TResult);
		}

		internal override void InnerInvoke()
		{
		}

		public new TaskAwaiter<TResult> GetAwaiter()
		{
			return default(TaskAwaiter<TResult>);
		}

		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(ConfiguredTaskAwaitable<TResult>);
		}

		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			return null;
		}

		internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}
	}
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
	public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
	{
		internal class ContingentProperties
		{
			internal ExecutionContext m_capturedContext;

			internal ManualResetEventSlim m_completionEvent;

			internal TaskExceptionHolder m_exceptionsHolder;

			internal CancellationToken m_cancellationToken;

			internal object m_cancellationRegistration;

			internal int m_internalCancellationRequested;

			internal int m_completionCountdown;

			internal LowLevelListWithIList<Task> m_exceptionalChildren;

			internal void SetCompleted()
			{
			}

			internal void UnregisterCancellationCallback()
			{
			}
		}

		private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
		{
			public bool InvokeMayRunArbitraryCode => false;

			internal SetOnInvokeMres()
				: base(initialState: false)
			{
			}

			public void Invoke(Task completingTask)
			{
			}
		}

		private sealed class DelayPromise : Task<VoidTaskResult>
		{
			internal readonly CancellationToken Token;

			internal CancellationTokenRegistration Registration;

			internal Timer Timer;

			internal DelayPromise(CancellationToken token)
			{
			}

			internal void Complete()
			{
			}
		}

		private sealed class WhenAllPromise<T> : Task<T[]>, ITaskCompletionAction
		{
			private readonly Task<T>[] m_tasks;

			private int m_count;

			internal override bool ShouldNotifyDebuggerOfWaitCompletion => false;

			public bool InvokeMayRunArbitraryCode => false;

			internal WhenAllPromise(Task<T>[] tasks)
			{
			}

			public void Invoke(Task ignored)
			{
			}
		}

		internal static int s_taskIdCounter;

		private int m_taskId;

		internal Delegate m_action;

		internal object m_stateObject;

		internal TaskScheduler m_taskScheduler;

		internal readonly Task m_parent;

		internal int m_stateFlags;

		private object m_continuationObject;

		private static readonly object s_taskCompletionSentinel;

		internal static bool s_asyncDebuggingEnabled;

		internal ContingentProperties m_contingentProperties;

		private static readonly Action<object> s_taskCancelCallback;

		[ThreadStatic]
		internal static Task t_currentTask;

		[ThreadStatic]
		private static StackGuard t_stackGuard;

		private static readonly Func<ContingentProperties> s_createContingentProperties;

		private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate;

		private static ContextCallback s_ecCallback;

		private static readonly Predicate<object> s_IsTaskContinuationNullPredicate;

		private static readonly Dictionary<int, Task> s_currentActiveTasks;

		private static readonly object s_activeTasksLock;

		internal TaskCreationOptions Options => default(TaskCreationOptions);

		internal bool IsWaitNotificationEnabledOrNotRanToCompletion
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion => false;

		internal bool IsWaitNotificationEnabled => false;

		public int Id => 0;

		internal static Task InternalCurrent => null;

		internal static StackGuard CurrentStackGuard => null;

		public AggregateException Exception => null;

		public TaskStatus Status => default(TaskStatus);

		public bool IsCanceled => false;

		internal bool IsCancellationRequested => false;

		internal CancellationToken CancellationToken => default(CancellationToken);

		internal bool IsCancellationAcknowledged => false;

		public bool IsCompleted => false;

		public bool IsCompletedSuccessfully => false;

		public TaskCreationOptions CreationOptions => default(TaskCreationOptions);

		WaitHandle IAsyncResult.AsyncWaitHandle => null;

		public object AsyncState => null;

		bool IAsyncResult.CompletedSynchronously => false;

		internal TaskScheduler ExecutingTaskScheduler => null;

		public static TaskFactory Factory { get; }

		public static Task CompletedTask { get; }

		internal ManualResetEventSlim CompletedEvent => null;

		internal bool ExceptionRecorded => false;

		public bool IsFaulted => false;

		internal ExecutionContext CapturedContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsExceptionObservedByParent => false;

		internal bool IsDelegateInvoked => false;

		internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct)
		{
		}

		internal Task()
		{
		}

		internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle)
		{
		}

		internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
		}

		private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation)
		{
		}

		private static void TaskCancelCallback(object o)
		{
		}

		internal bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			return false;
		}

		internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException)
		{
			return false;
		}

		internal bool TrySetException(object exceptionObject)
		{
			return false;
		}

		internal static TaskCreationOptions OptionsMethod(int flags)
		{
			return default(TaskCreationOptions);
		}

		internal bool AtomicStateUpdate(int newBits, int illegalBits)
		{
			return false;
		}

		internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags)
		{
			return false;
		}

		internal void SetNotificationForWaitCompletion(bool enabled)
		{
		}

		internal bool NotifyDebuggerOfWaitCompletionIfNecessary()
		{
			return false;
		}

		internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void NotifyDebuggerOfWaitCompletion()
		{
		}

		internal bool MarkStarted()
		{
			return false;
		}

		internal void AddNewChild()
		{
		}

		internal void DisregardChild()
		{
		}

		internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions)
		{
			return null;
		}

		internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions)
		{
			return null;
		}

		internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection)
		{
			return null;
		}

		private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection)
		{
			return null;
		}

		private static bool IsCompletedMethod(int flags)
		{
			return false;
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		internal void ScheduleAndStart(bool needsProtection)
		{
		}

		internal void AddException(object exceptionObject)
		{
		}

		internal void AddException(object exceptionObject, bool representsCancellation)
		{
		}

		private AggregateException GetExceptions(bool includeTaskCanceledExceptions)
		{
			return null;
		}

		internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			return null;
		}

		internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			return null;
		}

		internal void ThrowIfExceptional(bool includeTaskCanceledExceptions)
		{
		}

		internal void UpdateExceptionObservedStatus()
		{
		}

		internal void Finish(bool bUserDelegateExecuted)
		{
		}

		internal void FinishStageTwo()
		{
		}

		internal void FinishStageThree()
		{
		}

		internal void ProcessChildCompletion(Task childTask)
		{
		}

		internal void AddExceptionsFromChildren()
		{
		}

		private void Execute()
		{
		}

		void IThreadPoolWorkItem.ExecuteWorkItem()
		{
		}

		internal bool ExecuteEntry(bool bPreventDoubleExecution)
		{
			return false;
		}

		private static void ExecutionContextCallback(object obj)
		{
		}

		internal virtual void InnerInvoke()
		{
		}

		private void HandleException(Exception unhandledException)
		{
		}

		public TaskAwaiter GetAwaiter()
		{
			return default(TaskAwaiter);
		}

		public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			return default(ConfiguredTaskAwaitable);
		}

		internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext)
		{
		}

		public void Wait()
		{
		}

		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private bool WrappedTryRunInline()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			return false;
		}

		private bool SpinWait(int millisecondsTimeout)
		{
			return false;
		}

		internal bool InternalCancel(bool bCancelNonExecutingOnly)
		{
			return false;
		}

		internal void RecordInternalCancellationRequest()
		{
		}

		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord)
		{
		}

		internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException)
		{
		}

		internal void CancellationCleanupLogic()
		{
		}

		private void SetCancellationAcknowledged()
		{
		}

		internal void FinishContinuations()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void LogFinishCompletionNotification()
		{
		}

		public Task ContinueWith(Action<Task> continuationAction)
		{
			return null;
		}

		public Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler)
		{
			return null;
		}

		private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
		{
			return null;
		}

		private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			return null;
		}

		internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions)
		{
			creationOptions = default(TaskCreationOptions);
			internalOptions = default(InternalTaskOptions);
		}

		internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options)
		{
		}

		internal void AddCompletionAction(ITaskCompletionAction action)
		{
		}

		private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers)
		{
		}

		private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers)
		{
			return false;
		}

		private bool AddTaskContinuation(object tc, bool addBeforeOthers)
		{
			return false;
		}

		internal void RemoveContinuation(object continuationObject)
		{
		}

		public static Task<TResult> FromResult<TResult>(TResult result)
		{
			return null;
		}

		public static Task FromException(Exception exception)
		{
			return null;
		}

		public static Task<TResult> FromException<TResult>(Exception exception)
		{
			return null;
		}

		internal static Task FromCancellation(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task FromCanceled(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception)
		{
			return null;
		}

		public static Task Run(Action action)
		{
			return null;
		}

		public static Task<TResult> Run<TResult>(Func<TResult> function)
		{
			return null;
		}

		public static Task Run(Func<Task> function)
		{
			return null;
		}

		public static Task Run(Func<Task> function, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function)
		{
			return null;
		}

		public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task Delay(int millisecondsDelay)
		{
			return null;
		}

		public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<TResult[]> WhenAll<TResult>(params Task<TResult>[] tasks)
		{
			return null;
		}

		private static Task<TResult[]> InternalWhenAll<TResult>(Task<TResult>[] tasks)
		{
			return null;
		}

		public static Task<Task> WhenAny(params Task[] tasks)
		{
			return null;
		}

		public static Task<Task> WhenAny(IEnumerable<Task> tasks)
		{
			return null;
		}

		[FriendAccessAllowed]
		internal static bool AddToActiveTasks(Task task)
		{
			return false;
		}

		[FriendAccessAllowed]
		internal static void RemoveFromActiveTasks(int taskId)
		{
		}

		public void MarkAborted(ThreadAbortException e)
		{
		}

		private void ExecuteWithThreadLocal(ref Task currentTaskSlot)
		{
		}
	}
}
