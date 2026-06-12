using System;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Ignore specified events while this action is active.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class IgnoreEvents : FsmStateAction
	{
		[Serializable]
		public enum EventType
		{
			mouse = 0,
			application = 1,
			collision = 2,
			collision2d = 3,
			trigger = 4,
			trigger2d = 5,
			UI = 6,
			anyUnityEvent = 7
		}

		[Tooltip("Type of events to ignore.")]
		public EventType[] eventTypes;

		[Tooltip("Event names to ignore.")]
		[UIHint(UIHint.FsmEvent)]
		public FsmString[] events;

		[ActionSection("Debug")]
		[Tooltip("Log any events blocked by this action. Helpful for debugging.")]
		public FsmBool logIgnoredEvents;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override bool Event(FsmEvent fsmEvent)
		{
			return false;
		}

		private bool DoIgnoreEvent(FsmEvent fsmEvent)
		{
			return false;
		}
	}
}
