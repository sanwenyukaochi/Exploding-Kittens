using System.Diagnostics;

namespace HutongGames
{
	public static class LogHelper
	{
		[Conditional("DEBUG_LOG")]
		public static void LogWarning(object prefix, object message)
		{
		}

		[Conditional("DEBUG_LOG")]
		public static void Log(object message, LogColor logColor = LogColor.None)
		{
		}

		[Conditional("DEBUG_LOG")]
		public static void Log(object prefix, object message, LogColor logColor = LogColor.None)
		{
		}

		[Conditional("DEBUG_LOG")]
		public static void Log(object prefix, object message, object postfix, LogColor logColor = LogColor.None)
		{
		}

		private static object FormatLog(object message, LogColor logColor)
		{
			return null;
		}
	}
}
