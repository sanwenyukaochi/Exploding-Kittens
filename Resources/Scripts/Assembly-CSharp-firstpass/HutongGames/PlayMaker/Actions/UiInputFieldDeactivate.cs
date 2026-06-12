using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Deactivate a UI InputField to stop the processing of Events and send OnSubmit if not canceled. Optionally Activate on state exit")]
	public class UiInputFieldDeactivate : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Activate when exiting this state.")]
		public FsmBool activateOnExit;

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

		public override void OnExit()
		{
		}
	}
}
