using System;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmEventMapping
	{
		public FsmEvent fromEvent;

		public FsmEvent toEvent;

		public FsmEventMapping()
		{
		}

		public FsmEventMapping(FsmEvent fromEvent, FsmEvent toEvent)
		{
		}

		public FsmEventMapping(FsmEventMapping source)
		{
		}

		public FsmEventMapping Init()
		{
			return null;
		}
	}
}
