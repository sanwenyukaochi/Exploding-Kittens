using System.Collections.Generic;

namespace HutongGames.PlayMaker
{
	public class FsmLog
	{
		public static int MaxSize;

		private static readonly List<FsmLog> Logs;

		private static readonly FsmLogEntry[] logEntryPool;

		private static int nextLogEntryPoolIndex;

		private List<FsmLogEntry> entries;

		public static bool LoggingEnabled { get; set; }

		public static bool MirrorDebugLog { get; set; }

		public static bool EnableDebugFlow { get; set; }

		public Fsm Fsm { get; private set; }

		public List<FsmLogEntry> Entries => null;

		static FsmLog()
		{
		}

		private FsmLog(Fsm fsm)
		{
		}

		public static void InitInEditor()
		{
		}

		public static FsmLog GetLog(Fsm fsm)
		{
			return null;
		}

		public static void ClearLogs()
		{
		}

		private void AddEntry(FsmLogEntry entry, bool sendToUnityLog = false)
		{
		}

		private FsmLogEntry NewFsmLogEntry(FsmLogType logType)
		{
			return null;
		}

		private void RemoveEntry(FsmLogEntry entry)
		{
		}

		public void LogEvent(FsmEvent fsmEvent, FsmState state)
		{
		}

		public void LogSendEvent(FsmState state, FsmEvent fsmEvent, FsmEventTarget eventTarget)
		{
		}

		public void LogExitState(FsmState state)
		{
		}

		public void LogEnterState(FsmState state)
		{
		}

		public void LogTransition(FsmState fromState, FsmTransition transition)
		{
		}

		public void LogBreak()
		{
		}

		public void LogAction(FsmLogType logType, string text, bool sendToUnityLog = false)
		{
		}

		public void Log(FsmLogType logType, string text)
		{
		}

		public void LogStart(FsmState startState)
		{
		}

		public void LogStop()
		{
		}

		public void Log(string text)
		{
		}

		public void LogWarning(string text)
		{
		}

		public void LogError(string text)
		{
		}

		private string FormatUnityLogString(string text)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
