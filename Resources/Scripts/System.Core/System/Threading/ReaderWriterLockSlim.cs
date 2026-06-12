using System.Runtime.CompilerServices;

namespace System.Threading
{
	public class ReaderWriterLockSlim : IDisposable
	{
		private struct TimeoutTracker
		{
			private int m_total;

			private int m_start;

			public int RemainingMilliseconds => 0;

			public bool IsExpired => false;

			public TimeoutTracker(int millisecondsTimeout)
			{
				m_total = 0;
				m_start = 0;
			}
		}

		private bool fIsReentrant;

		private int myLock;

		private uint numWriteWaiters;

		private uint numReadWaiters;

		private uint numWriteUpgradeWaiters;

		private uint numUpgradeWaiters;

		private bool fNoWaiters;

		private int upgradeLockOwnerId;

		private int writeLockOwnerId;

		private EventWaitHandle writeEvent;

		private EventWaitHandle readEvent;

		private EventWaitHandle upgradeEvent;

		private EventWaitHandle waitUpgradeEvent;

		private static long s_nextLockID;

		private long lockID;

		[ThreadStatic]
		private static ReaderWriterCount t_rwc;

		private bool fUpgradeThreadHoldingRead;

		private uint owners;

		private bool fDisposed;

		public bool IsReadLockHeld => false;

		public bool IsUpgradeableReadLockHeld => false;

		public bool IsWriteLockHeld => false;

		public int RecursiveReadCount => 0;

		public int RecursiveUpgradeCount => 0;

		public int RecursiveWriteCount => 0;

		public int WaitingReadCount => 0;

		public int WaitingUpgradeCount => 0;

		public int WaitingWriteCount => 0;

		private void InitializeThreadCounts()
		{
		}

		public ReaderWriterLockSlim()
		{
		}

		public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
		{
			return false;
		}

		private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
		{
			return null;
		}

		public void EnterWriteLock()
		{
		}

		public bool TryEnterWriteLock(int millisecondsTimeout)
		{
			return false;
		}

		private bool TryEnterWriteLock(TimeoutTracker timeout)
		{
			return false;
		}

		private bool TryEnterWriteLockCore(TimeoutTracker timeout)
		{
			return false;
		}

		public void EnterUpgradeableReadLock()
		{
		}

		public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
		{
			return false;
		}

		private bool TryEnterUpgradeableReadLock(TimeoutTracker timeout)
		{
			return false;
		}

		private bool TryEnterUpgradeableReadLockCore(TimeoutTracker timeout)
		{
			return false;
		}

		public void ExitWriteLock()
		{
		}

		public void ExitUpgradeableReadLock()
		{
		}

		private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
		{
		}

		private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, TimeoutTracker timeout, bool isWriteWaiter)
		{
			return false;
		}

		private void ExitAndWakeUpAppropriateWaiters()
		{
		}

		private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
		{
		}

		private void ExitAndWakeUpAppropriateReadWaiters()
		{
		}

		private bool IsWriterAcquired()
		{
			return false;
		}

		private void SetWriterAcquired()
		{
		}

		private void ClearWriterAcquired()
		{
		}

		private void SetWritersWaiting()
		{
		}

		private void ClearWritersWaiting()
		{
		}

		private void SetUpgraderWaiting()
		{
		}

		private void ClearUpgraderWaiting()
		{
		}

		private uint GetNumReaders()
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void EnterMyLock()
		{
		}

		private void EnterMyLockSpin()
		{
		}

		private void ExitMyLock()
		{
		}

		private static void SpinWait(int SpinCount)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
