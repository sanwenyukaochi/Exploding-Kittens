using UnityEngine;

namespace HutongGames.PlayMaker
{
	public class FsmLogEntry
	{
		private string text;

		private string textWithTimecode;

		public FsmLog Log { get; set; }

		public FsmLogType LogType { get; set; }

		public Fsm Fsm => null;

		public FsmState State { get; set; }

		public FsmState SentByState { get; set; }

		public FsmStateAction Action { get; set; }

		public FsmEvent Event { get; set; }

		public FsmTransition Transition { get; set; }

		public FsmEventTarget EventTarget { get; set; }

		public float Time { get; set; }

		public float StateTime { get; set; }

		public int FrameCount { get; set; }

		public FsmVariables FsmVariablesCopy { get; set; }

		public FsmVariables GlobalVariablesCopy { get; set; }

		public GameObject GameObject { get; set; }

		public string GameObjectName { get; set; }

		public Texture GameObjectIcon { get; set; }

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Text2 { get; set; }

		public string TextWithTimecode => null;

		public int GetIndex()
		{
			return 0;
		}

		public void Reset()
		{
		}

		public void DebugLog()
		{
		}
	}
}
