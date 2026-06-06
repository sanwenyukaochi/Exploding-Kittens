using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the minimum and maximum limits for the value of a UI Slider component.")]
	public class UiSliderGetMinMax : ComponentAction<Slider>
	{
		[RequiredField]
		[Tooltip("The GameObject with the UI Slider component.")]
		[CheckForComponent(typeof(Slider))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Store the minimum value of the UI Slider.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat minValue;

		[Tooltip("Store the maximum value of the UI Slider.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat maxValue;

		private Slider slider;

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
