using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event when OnScroll is called on the GameObject. \nUse GetLastPointerDataInfo action to get info from the event")]
	public class UiOnScrollEvent : EventTriggerActionBase
	{
		[Tooltip("Event sent when OnScroll is called")]
		[UIHint(UIHint.Variable)]
		public FsmEvent onScrollEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnScrollDelegate(BaseEventData data)
		{
		}
	}
}
