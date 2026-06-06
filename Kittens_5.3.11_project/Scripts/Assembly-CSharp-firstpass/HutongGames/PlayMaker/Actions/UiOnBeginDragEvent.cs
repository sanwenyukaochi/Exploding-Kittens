using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event when user starts to drag a GameObject.\n Use GetLastPointerDataInfo action to get info from the event")]
	public class UiOnBeginDragEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnBeginDrag is called")]
		public FsmEvent onBeginDragEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnBeginDragDelegate(BaseEventData data)
		{
		}
	}
}
