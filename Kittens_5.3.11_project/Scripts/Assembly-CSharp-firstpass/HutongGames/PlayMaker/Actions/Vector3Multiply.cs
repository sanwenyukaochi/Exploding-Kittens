namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Multiplies a Vector3 variable by a Float.")]
	public class Vector3Multiply : FsmStateAction
	{
		[Tooltip("The vector3 variable to multiply.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Tooltip("The float to multiply each axis of the Vector3 variable by.")]
		[RequiredField]
		public FsmFloat multiplyBy;

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
