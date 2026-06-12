namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a XYZ values to Vector3 Variable.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3AddXYZ : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The Vector3 Variable to add to.")]
		public FsmVector3 vector3Variable;

		[Tooltip("Add to the X axis.")]
		public FsmFloat addX;

		[Tooltip("Add to the Y axis.")]
		public FsmFloat addY;

		[Tooltip("Add to the Z axis.")]
		public FsmFloat addZ;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Add over one second (multiplies values by Time.deltaTime). Note: Needs Every Frame checked.")]
		public bool perSecond;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoVector3AddXYZ()
		{
		}
	}
}
