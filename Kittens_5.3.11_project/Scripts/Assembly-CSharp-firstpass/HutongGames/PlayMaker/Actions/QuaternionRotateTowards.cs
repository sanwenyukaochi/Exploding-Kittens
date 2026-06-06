namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Rotates a rotation from towards to. This is essentially the same as Quaternion.Slerp but instead the function will ensure that the angular speed never exceeds maxDegreesDelta. Negative values of maxDegreesDelta pushes the rotation away from to.")]
	public class QuaternionRotateTowards : QuaternionBaseAction
	{
		[Tooltip("From Quaternion.")]
		[RequiredField]
		public FsmQuaternion fromQuaternion;

		[RequiredField]
		[Tooltip("To Quaternion.")]
		public FsmQuaternion toQuaternion;

		[RequiredField]
		[Tooltip("The angular speed never exceeds maxDegreesDelta. Negative values of maxDegreesDelta pushes the rotation away from to.")]
		public FsmFloat maxDegreesDelta;

		[RequiredField]
		[Tooltip("Store the result in this quaternion variable.")]
		[UIHint(UIHint.Variable)]
		public FsmQuaternion storeResult;

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

		private void DoQuatRotateTowards()
		{
		}
	}
}
