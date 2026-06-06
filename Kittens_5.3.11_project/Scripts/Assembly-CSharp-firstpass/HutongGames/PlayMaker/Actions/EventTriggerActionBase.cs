using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace HutongGames.PlayMaker.Actions
{
	public abstract class EventTriggerActionBase : ComponentAction<EventTrigger>
	{
		[DisplayOrder(0)]
		[RequiredField]
		[Tooltip("The GameObject with the UI component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		[DisplayOrder(1)]
		public FsmEventTarget eventTarget;

		protected EventTrigger trigger;

		protected EventTrigger.Entry entry;

		public override void Reset()
		{
		}

		protected void Init(EventTriggerType eventTriggerType, UnityAction<BaseEventData> call)
		{
		}

		public override void OnExit()
		{
		}
	}
}
