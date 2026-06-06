using System.Runtime.CompilerServices;

namespace System.Threading
{
	public static class ThreadPool
	{
		internal static bool IsThreadPoolThread => false;

		private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack, object state)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool QueueUserWorkItem(WaitCallback callBack)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state)
		{
			return false;
		}

		public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			return false;
		}

		private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			return false;
		}

		internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
		}

		internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			return false;
		}

		internal static bool RequestWorkerThread()
		{
			return false;
		}

		private static void EnsureVMInitialized()
		{
		}

		internal static bool NotifyWorkItemComplete()
		{
			return false;
		}

		internal static void ReportThreadStatus(bool isWorking)
		{
		}

		internal static void NotifyWorkItemProgress()
		{
		}

		internal static void NotifyWorkItemProgressNative()
		{
		}

		internal static void NotifyWorkItemQueued()
		{
		}

		private static void InitializeVMTp(ref bool enableWorkerTracking)
		{
		}
	}
}
