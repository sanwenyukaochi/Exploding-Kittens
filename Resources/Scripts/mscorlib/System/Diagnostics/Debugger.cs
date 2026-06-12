using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	[ComVisible(true)]
	public sealed class Debugger
	{
		public static readonly string DefaultCategory;

		public static bool IsLogging()
		{
			return false;
		}

		private static void Log_icall(int level, ref string category, ref string message)
		{
		}

		public static void Log(int level, string category, string message)
		{
		}

		public static void NotifyOfCrossThreadDependency()
		{
		}
	}
}
