using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Fires an event when editing ended in a UI InputField component. Event string data will contain the text value, and the boolean will be true is it was a cancel action")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldOnEndEditEvent : ComponentAction<InputField>
	{
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when editing ended.")]
		public FsmEvent sendEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("The content of the InputField when edited ended")]
		public FsmString text;

		[UIHint(UIHint.Variable)]
		[Tooltip("The canceled state of the InputField when edited ended")]
		public FsmBool wasCanceled;

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
