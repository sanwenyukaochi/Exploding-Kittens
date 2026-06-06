namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Inverse a quaternion")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class QuaternionInverse : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("the rotation")]
		public FsmQuaternion rotation;

		[Tooltip("Store the inverse of the rotation variable.")]
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

		private void DoQuatInverse()
		{
		}
	}
}
