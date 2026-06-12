namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Check if two quaternions are equals or not. Takes in account inversed representations of quaternions")]
	public class QuaternionCompare : QuaternionBaseAction
	{
		[RequiredField]
		[Tooltip("First Quaternion")]
		public FsmQuaternion Quaternion1;

		[Tooltip("Second Quaternion")]
		[RequiredField]
		public FsmQuaternion Quaternion2;

		[Tooltip("true if Quaternions are equal")]
		public FsmBool equal;

		[Tooltip("Event sent if Quaternions are equal")]
		public FsmEvent equalEvent;

		[Tooltip("Event sent if Quaternions are not equal")]
		public FsmEvent notEqualEvent;

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

		private void DoQuatCompare()
		{
		}
	}
}
