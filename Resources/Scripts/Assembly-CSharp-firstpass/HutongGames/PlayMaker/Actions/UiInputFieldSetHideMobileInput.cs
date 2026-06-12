using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Hide Mobile Input property of a UI InputField component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldSetHideMobileInput : ComponentAction<InputField>
	{
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Hide Mobile Input flag value of the UI InputField component.")]
		[UIHint(UIHint.TextArea)]
		[RequiredField]
		public FsmBool hideMobileInput;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private InputField inputField;

		private bool originalValue;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
