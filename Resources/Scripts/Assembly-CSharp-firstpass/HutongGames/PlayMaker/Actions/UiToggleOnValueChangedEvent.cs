using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Catches onValueChanged event in a UI Toggle component. Store the new value and/or send events. Event bool data will contain the new Toggle value")]
	public class UiToggleOnValueChangedEvent : ComponentAction<Toggle>
	{
		[Tooltip("The GameObject with the UI Toggle component.")]
		[CheckForComponent(typeof(Toggle))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when the value changes.")]
		public FsmEvent sendEvent;

		[Tooltip("Store the new value in bool variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool value;

		private Toggle toggle;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public void DoOnValueChanged(bool _value)
		{
		}
	}
}
