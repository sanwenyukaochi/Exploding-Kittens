using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Catches UI InputField onValueChanged event. Store the new value and/or send events. Event string data also contains the new value.")]
	public class UiInputFieldOnValueChangeEvent : ComponentAction<InputField>
	{
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when value changed.")]
		public FsmEvent sendEvent;

		[Tooltip("Store new value in string variable.")]
		[UIHint(UIHint.Variable)]
		public FsmString text;

		private InputField inputField;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public void DoOnValueChange(string value)
		{
		}
	}
}
