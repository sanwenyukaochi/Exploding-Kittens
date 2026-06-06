using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event Called by the EventSystem once dragging ends.\n Use GetLastPointerDataInfo action to get info from the event")]
	public class UiOnEndDragEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnEndDrag is called")]
		public FsmEvent onEndDragEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnEndDragDelegate(BaseEventData data)
		{
		}
	}
}
