namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Get the vector3 from a quaternion multiplied by a vector.")]
	public class GetQuaternionMultipliedByVector : QuaternionBaseAction
	{
		[Tooltip("The quaternion to multiply")]
		[RequiredField]
		public FsmQuaternion quaternion;

		[RequiredField]
		[Tooltip("The vector3 to multiply")]
		public FsmVector3 vector3;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting vector3")]
		public FsmVector3 result;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoQuatMult()
		{
		}
	}
}
