namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Creates a rotation that looks along forward with the head upwards along upwards.")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class QuaternionLookRotation : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("the rotation direction")]
		public FsmVector3 direction;

		[Tooltip("The up direction")]
		public FsmVector3 upVector;

		[RequiredField]
		[Tooltip("Store the inverse of the rotation variable.")]
		[UIHint(UIHint.Variable)]
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

		private void DoQuatLookRotation()
		{
		}
	}
}
