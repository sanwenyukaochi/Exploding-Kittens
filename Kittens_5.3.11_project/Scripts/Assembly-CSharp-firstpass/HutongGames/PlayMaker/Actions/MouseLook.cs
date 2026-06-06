namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Rotates a GameObject based on mouse movement. Minimum and Maximum values can be used to constrain the rotation.")]
	public class MouseLook : FsmStateAction
	{
		public enum RotationAxes
		{
			MouseXAndY = 0,
			MouseX = 1,
			MouseY = 2
		}

		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The axes to rotate around.")]
		public RotationAxes axes;

		[RequiredField]
		[Tooltip("Sensitivity of movement in X direction.")]
		public FsmFloat sensitivityX;

		[Tooltip("Sensitivity of movement in Y direction.")]
		[RequiredField]
		public FsmFloat sensitivityY;

		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around X axis. Set to None for no clamping.")]
		public FsmFloat minimumX;

		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around X axis. Set to None for no clamping.")]
		public FsmFloat maximumX;

		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around Y axis. Set to None for no clamping.")]
		public FsmFloat minimumY;

		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Clamp rotation around Y axis. Set to None for no clamping.")]
		public FsmFloat maximumY;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private float rotationX;

		private float rotationY;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMouseLook()
		{
		}

		private float GetXRotation()
		{
			return 0f;
		}

		private float GetYRotation()
		{
			return 0f;
		}

		private static float ClampAngle(float angle, FsmFloat min, FsmFloat max)
		{
			return 0f;
		}
	}
}
