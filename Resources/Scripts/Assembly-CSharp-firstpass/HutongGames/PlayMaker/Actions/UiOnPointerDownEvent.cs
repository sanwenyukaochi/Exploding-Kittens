using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when OnPointerDown is called on the GameObject.\n Use GetLastPointerDataInfo action to get info from the event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnPointerDownEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when PointerDown is called")]
		public FsmEvent onPointerDownEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnPointerDownDelegate(BaseEventData data)
		{
		}
	}
}
