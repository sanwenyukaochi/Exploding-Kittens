namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis (in that order).")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class QuaternionEuler : QuaternionBaseAction
	{
		[Tooltip("The Euler angles.")]
		[RequiredField]
		public FsmVector3 eulerAngles;

		[Tooltip("Store the euler angles of this quaternion variable.")]
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

		private void DoQuatEuler()
		{
		}
	}
}
