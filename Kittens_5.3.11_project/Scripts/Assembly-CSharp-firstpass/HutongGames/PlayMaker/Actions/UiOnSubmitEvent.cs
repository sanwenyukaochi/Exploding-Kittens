using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when OnSubmit is called on the GameObject. \nUse GetLastPointerDataInfo action to get info from the event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnSubmitEvent : EventTriggerActionBase
	{
		[Tooltip("Event sent when OnSubmitEvent is called")]
		[UIHint(UIHint.Variable)]
		public FsmEvent onSubmitEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnSubmitDelegate(BaseEventData data)
		{
		}
	}
}
