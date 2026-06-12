using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the normalized value (between 0 and 1) of a UI Slider component.")]
	public class UiSliderGetNormalizedValue : ComponentAction<Slider>
	{
		[Tooltip("The GameObject with the UI Slider component.")]
		[CheckForComponent(typeof(Slider))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The normalized value (between 0 and 1) of the UI Slider.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat value;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Slider slider;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
