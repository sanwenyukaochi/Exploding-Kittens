namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Cosine.")]
	public class GetCosine : FsmStateAction
	{
		[Tooltip("The angle. Note: Check Deg To Rad if the angle is expressed in degrees.")]
		[RequiredField]
		public FsmFloat angle;

		[Tooltip("Check if the angle is expressed in degrees.")]
		public FsmBool DegToRad;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The angle cosine.")]
		public FsmFloat result;

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

		private void DoCosine()
		{
		}
	}
}
