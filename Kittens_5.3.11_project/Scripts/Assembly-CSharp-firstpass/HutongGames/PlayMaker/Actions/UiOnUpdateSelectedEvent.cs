using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends event when Called by the EventSystem when the object associated with this EventTrigger is updated.\nUse GetLastPointerDataInfo action to get info from the event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiOnUpdateSelectedEvent : EventTriggerActionBase
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when OnUpdateSelected is called")]
		public FsmEvent onUpdateSelectedEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void OnUpdateSelectedDelegate(BaseEventData data)
		{
		}
	}
}
