namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the comparison of 2 Integers.")]
	public class IntCompare : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The first integer.")]
		public FsmInt integer1;

		[RequiredField]
		[Tooltip("The second integer.")]
		public FsmInt integer2;

		[Tooltip("Event sent if Integer 1 equals Integer 2")]
		public FsmEvent equal;

		[Tooltip("Event sent if Integer 1 is less than Integer 2")]
		public FsmEvent lessThan;

		[Tooltip("Event sent if Integer 1 is greater than Integer 2")]
		public FsmEvent greaterThan;

		[Tooltip("Perform this action every frame. Useful if you want to wait for a comparison to be true before sending an event.")]
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

		private void DoIntCompare()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
