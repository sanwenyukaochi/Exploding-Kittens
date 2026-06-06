namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Gets a quaternion as euler angles.")]
	public class GetQuaternionEulerAngles : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("The rotation")]
		public FsmQuaternion quaternion;

		[Tooltip("The euler angles of the quaternion.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmVector3 eulerAngles;

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

		private void GetQuatEuler()
		{
		}
	}
}
