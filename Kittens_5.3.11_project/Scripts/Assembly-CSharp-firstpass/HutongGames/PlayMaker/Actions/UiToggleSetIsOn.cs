using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the isOn property of a UI Toggle component.")]
	public class UiToggleSetIsOn : ComponentAction<Toggle>
	{
		[Tooltip("The GameObject with the UI Toggle component.")]
		[CheckForComponent(typeof(Toggle))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Should the toggle be on?")]
		[RequiredField]
		public FsmBool isOn;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Toggle _toggle;

		private bool _originalValue;

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
