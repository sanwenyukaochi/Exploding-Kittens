namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Subtracts a Vector3 value from a Vector3 variable.")]
	public class Vector3Subtract : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Vector3 variable to subtract from.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		[Tooltip("The Vector3 to subtract.")]
		[RequiredField]
		public FsmVector3 subtractVector;

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
