using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a Game Object around each Axis. Use a Vector3 Variable and/or XYZ components. To leave any axis unchanged, set variable to 'None'.")]
	public class Rotate : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The game object to rotate.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("A rotation vector specifying rotation around x, y, and z axis. NOTE: You can override individual axis below.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[Tooltip("Rotation around x axis.")]
		public FsmFloat xAngle;

		[Tooltip("Rotation around y axis.")]
		public FsmFloat yAngle;

		[Tooltip("Rotation around z axis.")]
		public FsmFloat zAngle;

		[Tooltip("Rotate in local or world space.")]
		public Space space;

		[Tooltip("Rotation is specified in degrees per second. In other words, the amount to rotate in over one second. This allows rotations to be frame rate independent. It is the same as multiplying the rotation by Time.deltaTime.")]
		public bool perSecond;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Perform the rotation in LateUpdate. This is useful if you want to override the rotation of objects that are animated or otherwise rotated in Update.")]
		public bool lateUpdate;

		[Tooltip("Perform the rotation in FixedUpdate. This is useful when working with rigid bodies and physics.")]
		public bool fixedUpdate;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
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

		private void DoRotate()
		{
		}
	}
}
