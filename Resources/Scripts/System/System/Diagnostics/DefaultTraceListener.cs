namespace System.Diagnostics
{
	public class DefaultTraceListener : TraceListener
	{
		private static readonly bool OnWin32;

		private static readonly string MonoTracePrefix;

		private static readonly string MonoTraceFile;

		private string logFileName;

		[System.MonoTODO]
		public string LogFileName => null;

		static DefaultTraceListener()
		{
		}

		private static string GetPrefix(string var, string target)
		{
			return null;
		}

		public DefaultTraceListener()
			: base(null)
		{
		}

		private unsafe static void WriteWindowsDebugString(char* message)
		{
		}

		private void WriteDebugString(string message)
		{
		}

		private void WriteMonoTrace(string message)
		{
		}

		private void WritePrefix()
		{
		}

		private void WriteImpl(string message)
		{
		}

		private void WriteLogFile(string message, string logFile)
		{
		}

		public override void Write(string message)
		{
		}

		public override void WriteLine(string message)
		{
		}
	}
}
