using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the Hide Mobile Input value of a UI InputField component.")]
	public class UiInputFieldGetHideMobileInput : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Store the Hide Mobile flag value of the UI InputField component.")]
		[UIHint(UIHint.Variable)]
		public FsmBool hideMobileInput;

		[Tooltip("Event sent if hide mobile input property is true")]
		public FsmEvent mobileInputHiddenEvent;

		[Tooltip("Event sent if hide mobile input property is false")]
		public FsmEvent mobileInputShownEvent;

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
