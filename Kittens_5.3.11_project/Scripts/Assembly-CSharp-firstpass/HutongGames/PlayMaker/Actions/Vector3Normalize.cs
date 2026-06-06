namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Normalizes a Vector3 Variable. A normalized vector has a length of 1.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3Normalize : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector3 Variable to normalize.")]
		public FsmVector3 vector3Variable;

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
	}
}
