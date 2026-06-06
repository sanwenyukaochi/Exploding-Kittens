namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Creates a rotation which rotates from fromDirection to toDirection. Usually you use this to rotate a transform so that one of its axes, e.g., the y-axis - follows a target direction toDirection in world space.")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class GetQuaternionFromRotation : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("the 'from' direction")]
		public FsmVector3 fromDirection;

		[Tooltip("the 'to' direction")]
		[RequiredField]
		public FsmVector3 toDirection;

		[RequiredField]
		[Tooltip("the resulting quaternion")]
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

		private void DoQuatFromRotation()
		{
		}
	}
}
