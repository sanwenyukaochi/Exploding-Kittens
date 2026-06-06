using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Asterix Character of a UI InputField component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldSetAsterixChar : ComponentAction<InputField>
	{
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The asterix Character used for password field type of the UI InputField component. Only the first character will be used, the rest of the string will be ignored")]
		public FsmString asterixChar;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private InputField inputField;

		private char originalValue;

		private static char __char__;

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
