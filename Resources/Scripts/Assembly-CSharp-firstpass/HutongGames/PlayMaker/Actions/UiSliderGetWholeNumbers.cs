using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the wholeNumbers property of a UI Slider component. If true, the Slider is constrained to integer values")]
	public class UiSliderGetWholeNumbers : ComponentAction<Slider>
	{
		[Tooltip("The GameObject with the UI Slider component.")]
		[CheckForComponent(typeof(Slider))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Is the Slider constrained to integer values?")]
		[UIHint(UIHint.Variable)]
		public FsmBool wholeNumbers;

		[Tooltip("Event sent if slider is showing integers")]
		public FsmEvent isShowingWholeNumbersEvent;

		[Tooltip("Event sent if slider is showing floats")]
		public FsmEvent isNotShowingWholeNumbersEvent;

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
