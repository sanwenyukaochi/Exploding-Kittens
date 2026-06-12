using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Fires an event when user submits from a UI InputField component. \nThis only fires if the user press Enter, not when field looses focus or user escaped the field.\nEvent string data will contain the text value.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldOnSubmitEvent : ComponentAction<InputField>
	{
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when editing ended.")]
		public FsmEvent sendEvent;

		[Tooltip("The content of the InputField when submitting")]
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

		public void DoOnEndEdit(string value)
		{
		}
	}
}
