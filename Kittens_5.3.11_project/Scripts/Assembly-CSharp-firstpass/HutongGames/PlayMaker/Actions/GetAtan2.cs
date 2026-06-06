namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the Arc Tangent 2 as in atan2(y,x). You can get the result in degrees, simply check on the RadToDeg conversion")]
	[ActionCategory(ActionCategory.Trigonometry)]
	public class GetAtan2 : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The x value of the tan")]
		public FsmFloat xValue;

		[RequiredField]
		[Tooltip("The y value of the tan")]
		public FsmFloat yValue;

		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		[RequiredField]
		public FsmFloat angle;

		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

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

		private void DoATan()
		{
		}
	}
}
