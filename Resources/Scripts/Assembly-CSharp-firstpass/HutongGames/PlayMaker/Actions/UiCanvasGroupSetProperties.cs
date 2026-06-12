using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets properties of a UI CanvasGroup component.")]
	public class UiCanvasGroupSetProperties : ComponentAction<CanvasGroup>
	{
		[CheckForComponent(typeof(CanvasGroup))]
		[RequiredField]
		[Tooltip("The GameObject with the UI CanvasGroup component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Canvas group alpha. Ranges from 0.0 to 1.0.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat alpha;

		[Tooltip("Is the group interactable (are the elements beneath the group enabled). Leave as None for no effect")]
		public FsmBool interactable;

		[Tooltip("Does this group block raycasting (allow collision). Leave as None for no effect")]
		public FsmBool blocksRaycasts;

		[Tooltip("Should the group ignore parent groups? Leave as None for no effect")]
		public FsmBool ignoreParentGroup;

		[Tooltip("Reset when exiting this state. Leave as None for no effect")]
		public FsmBool resetOnExit;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private CanvasGroup component;

		private float originalAlpha;

		private bool originalInteractable;

		private bool originalBlocksRaycasts;

		private bool originalIgnoreParentGroup;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
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
