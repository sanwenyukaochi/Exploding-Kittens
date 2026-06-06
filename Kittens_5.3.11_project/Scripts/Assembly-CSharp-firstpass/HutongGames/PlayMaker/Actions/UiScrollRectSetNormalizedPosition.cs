using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("The normalized scroll position as a Vector2 between (0,0) and (1,1) with (0,0) being the lower left corner.")]
	public class UiScrollRectSetNormalizedPosition : ComponentAction<ScrollRect>
	{
		[CheckForComponent(typeof(ScrollRect))]
		[RequiredField]
		[Tooltip("The GameObject with the UI ScrollRect component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The position's value of the UI ScrollRect component. Ranges from 0.0 to 1.0.")]
		public FsmVector2 normalizedPosition;

		[Tooltip("The horizontal position's value of the UI ScrollRect component. Ranges from 0.0 to 1.0.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat horizontalPosition;

		[Tooltip("The vertical position's value of the UI ScrollRect component. Ranges from 0.0 to 1.0.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat verticalPosition;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private ScrollRect scrollRect;

		private Vector2 originalValue;

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
