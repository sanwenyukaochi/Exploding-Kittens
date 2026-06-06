using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the text value of a UI InputField component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldSetText : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The text of the UI InputField component.")]
		[UIHint(UIHint.TextArea)]
		public FsmString text;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private InputField inputField;

		private string originalString;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetTextValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
