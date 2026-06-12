using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the wholeNumbers property of a UI Slider component. This defines if the slider will be constrained to integer values.")]
	public class UiSliderSetWholeNumbers : ComponentAction<Slider>
	{
		[RequiredField]
		[CheckForComponent(typeof(Slider))]
		[Tooltip("The GameObject with the UI Slider component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Should the slider be constrained to integer values?")]
		public FsmBool wholeNumbers;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Slider slider;

		private bool originalValue;

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
