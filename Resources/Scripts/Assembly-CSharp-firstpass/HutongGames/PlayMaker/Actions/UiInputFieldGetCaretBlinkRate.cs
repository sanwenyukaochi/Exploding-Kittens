using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the caret's blink rate of a UI InputField component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldGetCaretBlinkRate : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The caret's blink rate for the UI InputField component.")]
		public FsmFloat caretBlinkRate;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private InputField inputField;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
