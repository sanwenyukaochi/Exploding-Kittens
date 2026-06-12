using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the UI ScrollRect horizontal flag")]
	public class UiScrollRectSetHorizontal : ComponentAction<ScrollRect>
	{
		[RequiredField]
		[CheckForComponent(typeof(ScrollRect))]
		[Tooltip("The GameObject with the UI ScrollRect component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The horizontal flag")]
		public FsmBool horizontal;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private ScrollRect scrollRect;

		private bool originalValue;

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
