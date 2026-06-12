using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the caret's blink rate of a UI InputField component.")]
	public class UiInputFieldSetCaretBlinkRate : ComponentAction<InputField>
	{
		[RequiredField]
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The caret's blink rate for the UI InputField component.")]
		[RequiredField]
		public FsmInt caretBlinkRate;

		[Tooltip("Deactivate when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private InputField inputField;

		private float originalValue;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
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
