using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the minimum and maximum limits for the value of a UI Slider component. Optionally resets on exit")]
	public class UiSliderSetMinMax : ComponentAction<Slider>
	{
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the UI Slider component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The minimum value of the UI Slider component. Leave as None for no effect")]
		public FsmFloat minValue;

		[Tooltip("The maximum value of the UI Slider component. Leave as None for no effect")]
		public FsmFloat maxValue;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Slider slider;

		private float originalMinValue;

		private float originalMaxValue;

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
