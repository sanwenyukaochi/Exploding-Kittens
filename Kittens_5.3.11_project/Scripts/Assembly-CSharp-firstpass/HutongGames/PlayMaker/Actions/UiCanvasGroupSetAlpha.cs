using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Set Group Alpha.")]
	public class UiCanvasGroupSetAlpha : ComponentAction<CanvasGroup>
	{
		[Tooltip("The GameObject with a UI CanvasGroup component.")]
		[CheckForComponent(typeof(CanvasGroup))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The alpha of the UI component.")]
		public FsmFloat alpha;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private CanvasGroup component;

		private float originalValue;

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
