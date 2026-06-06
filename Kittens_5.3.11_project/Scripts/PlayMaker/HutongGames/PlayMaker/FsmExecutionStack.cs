using System.Collections.Generic;

namespace HutongGames.PlayMaker
{
	public static class FsmExecutionStack
	{
		private static readonly Stack<Fsm> fsmExecutionStack;

		public static Fsm ExecutingFsm => null;

		public static FsmState ExecutingState => null;

		public static string ExecutingStateName => null;

		public static FsmStateAction ExecutingAction => null;

		public static int StackCount => 0;

		public static int MaxStackCount { get; private set; }

		public static void Reset()
		{
		}

		public static void PushFsm(Fsm executingFsm)
		{
		}

		public static void PopFsm()
		{
		}

		public static string GetDebugString()
		{
			return null;
		}
	}
}
