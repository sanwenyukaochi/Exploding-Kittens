using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Catches UI Scrollbar onValueChanged event. Store the new value and/or send events. Event float data will contain the new Scrollbar value")]
	[ActionCategory(ActionCategory.UI)]
	public class UiScrollbarOnValueChanged : ComponentAction<Scrollbar>
	{
		[CheckForComponent(typeof(Scrollbar))]
		[Tooltip("The GameObject with the UI Scrollbar component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when the UI Scrollbar value changes.")]
		public FsmEvent sendEvent;

		[Tooltip("Store new value in float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat value;

		private Scrollbar scrollbar;

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
