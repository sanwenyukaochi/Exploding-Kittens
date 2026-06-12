using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	public static class GC
	{
		internal static readonly object EPHEMERON_TOMBSTONE;

		private static int GetCollectionCount(int generation)
		{
			return 0;
		}

		internal static void register_ephemeron_array(Ephemeron[] array)
		{
		}

		private static object get_ephemeron_tombstone()
		{
			return null;
		}

		internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
		{
			highMemLoadThreshold = default(uint);
			totalPhysicalMem = default(ulong);
			lastRecordedMemLoad = default(uint);
			lastRecordedHeapSize = default(UIntPtr);
			lastRecordedFragmentation = default(UIntPtr);
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int CollectionCount(int generation)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void KeepAlive(object obj)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private static void _SuppressFinalize(object o)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SuppressFinalize(object obj)
		{
		}

		private static void _ReRegisterForFinalize(object o)
		{
		}

		public static void ReRegisterForFinalize(object obj)
		{
		}

		public static long GetTotalMemory(bool forceFullCollection)
		{
			return 0L;
		}
	}
}
