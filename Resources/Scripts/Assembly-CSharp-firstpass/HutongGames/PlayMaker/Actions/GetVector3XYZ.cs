namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Get the XYZ channels of a Vector3 Variable and store them in Float Variables.")]
	public class GetVector3XYZ : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector3 variable to examine.")]
		public FsmVector3 vector3Variable;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store X value in a float variable.")]
		public FsmFloat storeX;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store Y value in a float variable.")]
		public FsmFloat storeY;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store Z value in a float variable.")]
		public FsmFloat storeZ;

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

		private void DoGetVector3XYZ()
		{
		}
	}
}
