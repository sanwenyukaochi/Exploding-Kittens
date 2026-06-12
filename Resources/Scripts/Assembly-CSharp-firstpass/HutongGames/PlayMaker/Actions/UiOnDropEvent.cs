using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when OnDrop is called on the GameObject. Warning this event is sent everyframe while dragging.\n Use GetLastPointerDataInfo action to get info from the event.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnDropEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnDrop is called")]
		public FsmEvent onDropEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnDropDelegate(BaseEventData data)
		{
		}
	}
}
