namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan : FsmStateAction
	{
		[Tooltip("The value of the tan")]
		[RequiredField]
		public FsmFloat Value;

		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat angle;

		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		[Tooltip("Repeat Every Frame")]
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
