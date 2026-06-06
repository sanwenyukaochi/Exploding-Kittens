namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Quaternion)]
	[Tooltip("Spherically interpolates between from and to by t.")]
	public class QuaternionSlerp : QuaternionBaseAction
	{
		[Tooltip("From Quaternion.")]
		[RequiredField]
		public FsmQuaternion fromQuaternion;

		[Tooltip("To Quaternion.")]
		[RequiredField]
		public FsmQuaternion toQuaternion;

		[HasFloatSlider(0f, 1f)]
		[RequiredField]
		[Tooltip("Interpolate between fromQuaternion and toQuaternion by this amount. Value is clamped to 0-1 range. 0 = fromQuaternion; 1 = toQuaternion; 0.5 = half way between.")]
		public FsmFloat amount;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in this quaternion variable.")]
		[RequiredField]
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

		private void DoQuatSlerp()
		{
		}
	}
}
