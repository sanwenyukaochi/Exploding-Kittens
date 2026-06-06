using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when OnPointerUp is called on the GameObject. \nUse GetLastPointerDataInfo action to get info from the event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnPointerUpEvent : EventTriggerActionBase
	{
		[Tooltip("Event sent when PointerUp is called")]
		[UIHint(UIHint.Variable)]
		public FsmEvent onPointerUpEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnPointerUpDelegate(BaseEventData data)
		{
		}
	}
}
