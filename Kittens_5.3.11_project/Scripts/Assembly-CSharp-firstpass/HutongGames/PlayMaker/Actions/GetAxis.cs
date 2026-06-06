namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the value of the specified Input Axis and stores it in a Float Variable. See {{Unity Input Manager}} docs.")]
	[SeeAlso("Unity Input Manager")]
	public class GetAxis : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The name of the axis. Set in the Unity Input Manager.")]
		public FsmString axisName;

		[Tooltip("Normally axis values are in the range -1 to 1. Use the multiplier to make this range bigger. E.g., A multiplier of 100 returns values from -100 to 100.")]
		public FsmFloat multiplier;

		[Tooltip("Invert the value of for the axis. E.g., -1 becomes 1, and 1 becomes -1.")]
		public FsmBool invert;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a float variable.")]
		[RequiredField]
		public FsmFloat store;

		[Tooltip("Get the axis value every frame. This should be true most of the time, but there might be times when you only want to get the value once.")]
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

		private void DoGetAxis()
		{
		}
	}
}
