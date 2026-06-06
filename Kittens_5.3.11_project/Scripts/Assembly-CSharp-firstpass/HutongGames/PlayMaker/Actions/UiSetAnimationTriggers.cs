using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Animation Triggers of a UI Selectable component. Modifications will not be visible if transition is not Animation")]
	[ActionCategory(ActionCategory.UI)]
	public class UiSetAnimationTriggers : ComponentAction<Selectable>
	{
		[Tooltip("The GameObject with the UI Selectable component.")]
		[CheckForComponent(typeof(Selectable))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The normal trigger value. Leave as None for no effect")]
		public FsmString normalTrigger;

		[Tooltip("The highlighted trigger value. Leave as None for no effect")]
		public FsmString highlightedTrigger;

		[Tooltip("The pressed trigger value. Leave as None for no effect")]
		public FsmString pressedTrigger;

		[Tooltip("The disabled trigger value. Leave as None for no effect")]
		public FsmString disabledTrigger;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Selectable selectable;

		private AnimationTriggers _animationTriggers;

		private AnimationTriggers originalAnimationTriggers;

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
