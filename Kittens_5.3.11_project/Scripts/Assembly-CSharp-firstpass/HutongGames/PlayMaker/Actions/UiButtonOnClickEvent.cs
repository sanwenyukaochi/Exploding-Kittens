using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sends an event when a UI Button is clicked.")]
	public class UiButtonOnClickEvent : ComponentAction<Button>
	{
		[Tooltip("The GameObject with the UI Button component.")]
		[RequiredField]
		[CheckForComponent(typeof(Button))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Where to send the event.")]
		public FsmEventTarget eventTarget;

		[Tooltip("Send this event when Clicked.")]
		public FsmEvent sendEvent;

		private Button button;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public void DoOnClick()
		{
		}
	}
}
