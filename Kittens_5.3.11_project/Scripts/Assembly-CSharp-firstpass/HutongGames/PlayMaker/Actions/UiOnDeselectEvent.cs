using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event when OnDeselect is called on the GameObject.\n Use GetLastPointerDataInfo action to get info from the event")]
	public class UiOnDeselectEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnDeselectEvent is called")]
		public FsmEvent onDeselectEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnDeselectDelegate(BaseEventData data)
		{
		}
	}
}
