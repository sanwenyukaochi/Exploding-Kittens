using System.Collections.Generic;

namespace HutongGames.PlayMaker
{
	public class ActionReport
	{
		public static readonly List<ActionReport> ActionReportList;

		public static int InfoCount;

		public static int ErrorCount;

		public Fsm fsm;

		public FsmState state;

		public FsmStateAction action;

		public int actionIndex;

		public string logText;

		public bool isError;

		public string parameter;

		public static void Start()
		{
		}

		public static ActionReport Log(Fsm fsm, FsmState state, FsmStateAction action, int actionIndex, string parameter, string logLine, bool isError = false)
		{
			return null;
		}

		private static bool ActionReportContains(ActionReport report)
		{
			return false;
		}

		private bool SameAs(ActionReport actionReport)
		{
			return false;
		}

		public static void LogWarning(Fsm fsm, FsmState state, FsmStateAction action, int actionIndex, string parameter, string logLine)
		{
		}

		public static void LogError(Fsm fsm, FsmState state, FsmStateAction action, int actionIndex, string parameter, string logLine)
		{
		}

		public static void LogError(Fsm fsm, FsmState state, FsmStateAction action, int actionIndex, string logLine)
		{
		}

		public static void Clear()
		{
		}

		public static void Remove(Fsm fsm)
		{
		}

		public static int GetCount()
		{
			return 0;
		}
	}
}
