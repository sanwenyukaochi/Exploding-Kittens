namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of an Integer Variable.")]
	public class IntSwitch : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The integer variable to test.")]
		public FsmInt intVariable;

		[CompoundArray("Int Switches", "Compare Int", "Send Event")]
		[Tooltip("The integer variable to test.")]
		public FsmInt[] compareTo;

		[Tooltip("Event to send if true.")]
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

		private void DoIntSwitch()
		{
		}
	}
}
