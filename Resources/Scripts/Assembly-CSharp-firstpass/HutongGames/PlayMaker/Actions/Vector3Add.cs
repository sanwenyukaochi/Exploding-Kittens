namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a value to Vector3 Variable.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3Add : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Vector3 variable to add to.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		[RequiredField]
		[Tooltip("Vector3 to add.")]
		public FsmVector3 addVector;

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

		private void DoVector3Add()
		{
		}
	}
}
