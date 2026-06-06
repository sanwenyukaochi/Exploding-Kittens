using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event when Called by the EventSystem when a Select event occurs. \nUse GetLastPointerDataInfo action to get info from the event")]
	public class UiOnSelectEvent : EventTriggerActionBase
	{
		[Tooltip("Event sent when OnSelect is called")]
		[UIHint(UIHint.Variable)]
		public FsmEvent onSelectEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnSelectDelegate(BaseEventData data)
		{
		}
	}
}
