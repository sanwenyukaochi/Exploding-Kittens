namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event based on the value of a Float Variable. The float could represent distance, angle to a target, health left... The array sets up float ranges that correspond to Events.")]
	[ActionCategory(ActionCategory.Logic)]
	public class FloatSwitch : FsmStateAction
	{
		[Tooltip("The float variable to test.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		[CompoundArray("Float Switches", "Less Than", "Send Event")]
		[Tooltip("Test if the float is less than a value. Each entry in the array defines a range between it and the previous entry.")]
		public FsmFloat[] lessThan;

		[Tooltip("Event to send if true.")]
		public FsmEvent[] sendEvent;

		[Tooltip("Repeat every frame. Useful if the variable is changing.")]
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

		private void DoFloatSwitch()
		{
		}
	}
}
