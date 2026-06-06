using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Catches onValueChanged event for a UI Slider component. Store the new value and/or send events. Event float data will contain the new slider value")]
	[ActionCategory(ActionCategory.UI)]
	public class UiSliderOnValueChangedEvent : ComponentAction<Slider>
	{
		[CheckForComponent(typeof(Slider))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Slider component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when Clicked.")]
		public FsmEvent sendEvent;

		[Tooltip("Store the new value in float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat value;

		private Slider slider;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public void DoOnValueChanged(float _value)
		{
		}
	}
}
