using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when OnPointerEnter is called on the GameObject.\n Use GetLastPointerDataInfo action to get info from the event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnPointerEnterEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when PointerEnter is called")]
		public FsmEvent onPointerEnterEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnPointerEnterDelegate(BaseEventData data)
		{
		}
	}
}
