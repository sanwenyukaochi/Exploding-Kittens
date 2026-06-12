using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the cancel state of a UI InputField component. This relates to the last onEndEdit Event")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldGetWasCanceled : ComponentAction<InputField>
	{
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The was canceled flag value of the UI InputField component.")]
		public FsmBool wasCanceled;

		[Tooltip("Event sent if inputField was canceled")]
		public FsmEvent wasCanceledEvent;

		[Tooltip("Event sent if inputField was not canceled")]
		public FsmEvent wasNotCanceledEvent;

		private InputField inputField;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
