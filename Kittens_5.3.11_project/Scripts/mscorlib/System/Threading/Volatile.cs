using System.Runtime.CompilerServices;

namespace System.Threading
{
	public static class Volatile
	{
		private struct VolatileBoolean
		{
			public bool Value;
		}

		private struct VolatileInt32
		{
			public int Value;
		}

		private struct VolatileObject
		{
			public object Value;
		}

		[Intrinsic]
		public static bool Read(ref bool location)
		{
			return false;
		}

		[Intrinsic]
		public static int Read(ref int location)
		{
			return 0;
		}

		[Intrinsic]
		public static void Write(ref int location, int value)
		{
		}

		[Intrinsic]
		public static T Read<T>(ref T location) where T : class
		{
			return null;
		}

		[Intrinsic]
		public static void Write<T>(ref T location, T value) where T : class
		{
		}
	}
}
