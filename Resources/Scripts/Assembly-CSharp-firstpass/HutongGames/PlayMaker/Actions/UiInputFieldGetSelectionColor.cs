using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the selection color of a UI InputField component. This is the color of the highlighter to show what characters are selected")]
	public class UiInputFieldGetSelectionColor : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("This is the color of the highlighter to show what characters are selected of the UI InputField component.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmColor selectionColor;

		[Tooltip("Repeats every frame")]
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
