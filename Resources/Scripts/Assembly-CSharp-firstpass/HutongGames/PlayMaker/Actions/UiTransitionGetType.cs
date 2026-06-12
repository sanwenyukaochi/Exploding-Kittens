using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the transition type of a UI Selectable component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiTransitionGetType : ComponentAction<Selectable>
	{
		[CheckForComponent(typeof(Selectable))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Selectable component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The transition value")]
		public FsmString transition;

		[Tooltip("Event sent if transition is ColorTint")]
		public FsmEvent colorTintEvent;

		[Tooltip("Event sent if transition is SpriteSwap")]
		public FsmEvent spriteSwapEvent;

		[Tooltip("Event sent if transition is Animation")]
		public FsmEvent animationEvent;

		[Tooltip("Event sent if transition is none")]
		public FsmEvent noTransitionEvent;

		private Selectable selectable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
