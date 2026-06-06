using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Move Caret to text start in a UI InputField component. Optionally select from the current caret position")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldMoveCaretToTextStart : ComponentAction<InputField>
	{
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Define if we select or not from the current caret position. Default is true = no selection")]
		public FsmBool shift;

		private InputField inputField;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoAction()
		{
		}
	}
}
