using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the interactable flag of a UI Selectable component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiSetIsInteractable : FsmStateAction
	{
		[Tooltip("The GameObject with the UI Selectable component.")]
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Interactable value")]
		public FsmBool isInteractable;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Selectable _selectable;

		private bool _originalState;

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
