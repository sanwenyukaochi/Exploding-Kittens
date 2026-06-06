namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets the rotation of the device around its z axis (into the screen). For example when you steer with the iPhone in a driving game.")]
	public class GetDeviceRoll : FsmStateAction
	{
		public enum BaseOrientation
		{
			Portrait = 0,
			LandscapeLeft = 1,
			LandscapeRight = 2
		}

		[Tooltip("How the user is expected to hold the device (where angle will be zero).")]
		public BaseOrientation baseOrientation;

		[Tooltip("Store the roll angle in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeAngle;

		[Tooltip("Limit the roll angle.")]
		public FsmFloat limitAngle;

		[Tooltip("Smooth the roll angle as it changes. You can play with this value to balance responsiveness and lag/smoothness.")]
		public FsmFloat smoothing;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private float lastZAngle;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetDeviceRoll()
		{
		}
	}
}
