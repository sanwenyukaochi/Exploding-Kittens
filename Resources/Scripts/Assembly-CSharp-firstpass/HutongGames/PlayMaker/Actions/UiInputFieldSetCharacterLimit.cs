using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the maximum number of characters that the user can type into a UI InputField component. Optionally reset on exit")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldSetCharacterLimit : ComponentAction<InputField>
	{
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The maximum number of characters that the user can type into the UI InputField component. 0 = infinite")]
		[RequiredField]
		public FsmInt characterLimit;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private InputField inputField;

		private int originalValue;

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
