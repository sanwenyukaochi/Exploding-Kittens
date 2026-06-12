using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when OnPointerExit is called on the GameObject. \nUse GetLastPointerDataInfo action to get info from the event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnPointerExitEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when PointerExit is called")]
		public FsmEvent onPointerExitEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnPointerExitDelegate(BaseEventData data)
		{
		}
	}
}
