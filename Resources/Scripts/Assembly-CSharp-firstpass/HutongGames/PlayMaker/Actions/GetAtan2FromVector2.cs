namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent 2 as in atan2(y,x) from a vector 2. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan2FromVector2 : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The vector2 of the tan")]
		public FsmVector2 vector2;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
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
