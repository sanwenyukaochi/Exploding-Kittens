using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Rotates a GameObject based on mouse movement. Minimum and Maximum values can be used to constrain the rotation.")]
	public class MouseLook2 : ComponentAction<Rigidbody>
	{
		public enum RotationAxes
		{
			MouseXAndY = 0,
			MouseX = 1,
			MouseY = 2
		}

		[Tooltip("The GameObject to rotate.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The axes to rotate around.")]
		public RotationAxes axes;

		[RequiredField]
		[Tooltip("Speed around X axis. Higher = faster.")]
		public FsmFloat sensitivityX;

		[RequiredField]
		[Tooltip("Speed around Y axis. Higher = faster.")]
		public FsmFloat sensitivityY;

		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Minimum angle around X axis.")]
		public FsmFloat minimumX;

		[Tooltip("Maximum angle around X axis.")]
		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		public FsmFloat maximumX;

		[Tooltip("Minimum angle around Y axis.")]
		[HasFloatSlider(-360f, 360f)]
		[RequiredField]
		public FsmFloat minimumY;

		[RequiredField]
		[HasFloatSlider(-360f, 360f)]
		[Tooltip("Maximum angle around X axis.")]
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
