using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the text value of a UI InputField component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldGetText : ComponentAction<InputField>
	{
		[RequiredField]
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The text value of the UI InputField component.")]
		public FsmString text;

		[Tooltip("Repeat every frame.")]
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

		private void DoGetTextValue()
		{
		}
	}
}
