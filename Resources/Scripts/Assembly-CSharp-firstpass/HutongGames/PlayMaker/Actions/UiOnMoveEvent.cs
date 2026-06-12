using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends event when OnMoveEvent is called on the GameObject.\n Use GetLastPointerDataInfo action to get info from the event")]
	public class UiOnMoveEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnMoveEvent is called")]
		public FsmEvent onMoveEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnMoveDelegate(BaseEventData data)
		{
		}
	}
}
