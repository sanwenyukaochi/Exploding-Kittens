using System.Runtime.ConstrainedExecution;

namespace System.Runtime.CompilerServices
{
	public static class RuntimeHelpers
	{
		public static int OffsetToStringData => 0;

		private static void InitializeArray(Array array, IntPtr fldHandle)
		{
		}

		public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
		}

		public static int GetHashCode(object o)
		{
			return 0;
		}

		public static object GetObjectValue(object obj)
		{
			return null;
		}

		private static void RunClassConstructor(IntPtr type)
		{
		}

		public static void RunClassConstructor(RuntimeTypeHandle type)
		{
		}

		private static bool SufficientExecutionStack()
		{
			return false;
		}

		public static bool TryEnsureSufficientExecutionStack()
		{
			return false;
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void PrepareConstrainedRegions()
		{
		}

		public static bool IsReferenceOrContainsReferences<T>()
		{
			return false;
		}
	}
}
