namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the quaternion from a quaternion multiplied by a quaternion.")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class GetQuaternionMultipliedByQuaternion : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("The first quaternion to multiply")]
		public FsmQuaternion quaternionA;

		[RequiredField]
		[Tooltip("The second quaternion to multiply")]
		public FsmQuaternion quaternionB;

		[Tooltip("The resulting quaternion")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmQuaternion result;

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
