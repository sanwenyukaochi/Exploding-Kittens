using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the selection color of a UI InputField component. This is the color of the highlighter to show what characters are selected.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldSetSelectionColor : ComponentAction<InputField>
	{
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The color of the highlighter to show what characters are selected for the UI InputField component.")]
		[RequiredField]
		public FsmColor selectionColor;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private InputField inputField;

		private Color originalValue;

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
