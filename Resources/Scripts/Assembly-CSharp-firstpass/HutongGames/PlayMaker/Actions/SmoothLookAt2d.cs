using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Smoothly Rotates a 2d Game Object so its right vector points at a Target. The target can be defined as a 2d Game Object or a 2d/3d world Position. If you specify both, then the position will be used as a local offset from the object's position.")]
	[ActionCategory(ActionCategory.Transform)]
	public class SmoothLookAt2d : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to rotate to face a target.")]
		public FsmOwnerDefault gameObject;

		[ActionSection("Target")]
		[Tooltip("A target GameObject.")]
		public FsmGameObject targetObject;

		[Tooltip("A target position. If a Target Object is defined, this is used as a local offset.")]
		public FsmVector2 targetPosition2d;

		[Tooltip("A target position. If a Target Object is defined, this is used as a local offset.")]
		public FsmVector3 targetPosition;

		[ActionSection("Rotation")]
		[Tooltip("Set the GameObject starting offset. In degrees. 0 if your object is facing right, 180 if facing left etc...")]
		public FsmFloat rotationOffset;

		[Tooltip("How fast to rotate to look at the target. Higher numbers are faster. Note, you can enter numbers outside the slider range.")]
		[HasFloatSlider(0.5f, 15f)]
		public FsmFloat speed;

		[Tooltip("Set min/max angle limits for the look at rotation. Note, you can use a scene gizmo to set the angles.")]
		public FsmBool useLimits;

		[Tooltip("Min angle limit.")]
		[HideIf("HideLimits")]
		public FsmFloat minAngle;

		[HideIf("HideLimits")]
		[Tooltip("Max angle limit.")]
		public FsmFloat maxAngle;

		[Tooltip("Draw a line in the Scene View to the look at position.")]
		public FsmBool debug;

		[ActionSection("Finished")]
		[Tooltip("If the angle to the target is less than this, send the Finish Event below. Measured in degrees.")]
		public FsmFloat finishTolerance;

		[Tooltip("Event to send if the angle to target is less than the Finish Tolerance.")]
		public FsmEvent finishEvent;

		[Tooltip("Should the event stop running when it succeeds.")]
		public FsmBool finish;

		private GameObject previousGo;

		private Quaternion lastRotation;

		private Quaternion desiredRotation;

		private Vector3 lookAtPos;

		public override void Reset()
		{
		}

		public bool HideLimits()
		{
			return false;
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void DoSmoothLookAt()
		{
		}

		private float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}
	}
}
