using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the transition type of a UI Selectable component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiTransitionSetType : ComponentAction<Selectable>
	{
		[Tooltip("The GameObject with the UI Selectable component.")]
		[CheckForComponent(typeof(Selectable))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The transition value")]
		public Selectable.Transition transition;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Selectable selectable;

		private Selectable.Transition originalTransition;

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
