namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent 2 as in atan2(y,x) from a vector 3, where you pick which is x and y from the vector 3. You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan2FromVector3 : FsmStateAction
	{
		public enum aTan2EnumAxis
		{
			x = 0,
			y = 1,
			z = 2
		}

		[Tooltip("The vector3 definition of the tan")]
		[RequiredField]
		public FsmVector3 vector3;

		[RequiredField]
		[Tooltip("which axis in the vector3 to use as the x value of the tan")]
		public aTan2EnumAxis xAxis;

		[RequiredField]
		[Tooltip("which axis in the vector3 to use as the y value of the tan")]
		public aTan2EnumAxis yAxis;

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
