namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event based on the value of an Enum Variable.")]
	[ActionCategory(ActionCategory.Logic)]
	public class EnumSwitch : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Enum Variable to use.")]
		public FsmEnum enumVariable;

		[Tooltip("Compare Enum Values")]
		[CompoundArray("Enum Switches", "Compare Enum Value", "Send Event")]
		[MatchFieldType("enumVariable")]
		public FsmEnum[] compareTo;

		[Tooltip("Event to send if the Enum Variable value is equal.")]
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

		private void DoEnumSwitch()
		{
		}
	}
}
