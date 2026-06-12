namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event based on a Game Object's Tag.")]
	[ActionCategory(ActionCategory.Logic)]
	public class GameObjectTagSwitch : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject to test.")]
		public FsmGameObject gameObject;

		[CompoundArray("Tag Switches", "Compare Tag", "Send Event")]
		[UIHint(UIHint.Tag)]
		[Tooltip("Compare GameObject's Tag.")]
		public FsmString[] compareTo;

		[Tooltip("Send this event if Tag matches.")]
		public FsmEvent[] sendEvent;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoTagSwitch()
		{
		}
	}
}
