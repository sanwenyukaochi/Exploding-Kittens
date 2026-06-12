using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	[ComVisible(true)]
	public sealed class ReaderWriterLock : CriticalFinalizerObject
	{
		private int seq_num;

		private int state;

		private int readers;

		private int writer_lock_owner;

		private LockQueue writer_queue;

		private Hashtable reader_locks;

		~ReaderWriterLock()
		{
		}

		public void AcquireWriterLock(int millisecondsTimeout)
		{
		}

		private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public void ReleaseWriterLock()
		{
		}

		private void ReleaseWriterLock(int releaseCount)
		{
		}

		private bool HasWriterLock()
		{
			return false;
		}
	}
}
