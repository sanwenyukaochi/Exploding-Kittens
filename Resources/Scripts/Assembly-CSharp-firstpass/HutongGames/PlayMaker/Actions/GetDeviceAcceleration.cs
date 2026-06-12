namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the last measured linear acceleration of a device and stores it in a Vector3 Variable.")]
	[ActionCategory(ActionCategory.Device)]
	public class GetDeviceAcceleration : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the acceleration in a Vector3 Variable.")]
		public FsmVector3 storeVector;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the x component of the acceleration in a Float Variable.")]
		public FsmFloat storeX;

		[Tooltip("Store the y component of the acceleration in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

		[Tooltip("Store the z component of the acceleration in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeZ;

		[Tooltip("Multiply the acceleration by a float value.")]
		public FsmFloat multiplier;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetDeviceAcceleration()
		{
		}
	}
}
