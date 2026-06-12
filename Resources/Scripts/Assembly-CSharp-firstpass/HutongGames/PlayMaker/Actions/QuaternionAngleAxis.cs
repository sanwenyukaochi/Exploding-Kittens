namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Creates a rotation which rotates angle degrees around axis.")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class QuaternionAngleAxis : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("The angle.")]
		public FsmFloat angle;

		[Tooltip("The rotation axis.")]
		[RequiredField]
		public FsmVector3 axis;

		[Tooltip("Store the rotation of this quaternion variable.")]
		[RequiredField]
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

		private void DoQuatAngleAxis()
		{
		}
	}
}
