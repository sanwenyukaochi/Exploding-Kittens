namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Reverses the direction of a Vector3 Variable. Same as multiplying by -1.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3Invert : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector3 variable to invert.")]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Tooltip("Repeat every frame")]
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
