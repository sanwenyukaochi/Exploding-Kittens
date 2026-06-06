using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Clamps a rotation around a local axis. Optionally define the default rotation. Clamp is done on LateUpdate")]
	public class ClampRotation : FsmStateAction
	{
		public enum ConstraintAxis
		{
			x = 0,
			y = 1,
			z = 2
		}

		[RequiredField]
		[Tooltip("The GameObject to clamp rotation.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The default rotation. If none, will use the GameObject target.")]
		public FsmVector3 defaultRotation;

		[ObjectType(typeof(ConstraintAxis))]
		[Tooltip("The axis to constraint the rotation")]
		public FsmEnum constraintAxis;

		[Tooltip("The minimum angle allowed")]
		public FsmFloat minAngle;

		[Tooltip("The maximum angle allowed")]
		public FsmFloat maxAngle;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		private float angleFromMin;

		private float angleFromMax;

		private Transform thisTransform;

		private Vector3 rotateAround;

		private Quaternion minQuaternion;

		private Quaternion maxQuaternion;

		private float range;

		private ConstraintAxis axis;

		private int axisIndex;

		private Quaternion axisRotation;

		private Vector3 _defaultRotation;

		public override void Reset()
		{
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

		private void DoClampRotation()
		{
		}

		private void ComputeRange()
		{
		}
	}
}
