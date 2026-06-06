namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of a String Variable.")]
	public class StringSwitch : FsmStateAction
	{
		[Tooltip("The String Variable to test.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmString stringVariable;

		[CompoundArray("String Switches", "Compare String", "Send Event")]
		[Tooltip("Compare to a string value.")]
		public FsmString[] compareTo;

		[Tooltip("Send this event if string matches.")]
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

		private void DoStringSwitch()
		{
		}
	}
}
