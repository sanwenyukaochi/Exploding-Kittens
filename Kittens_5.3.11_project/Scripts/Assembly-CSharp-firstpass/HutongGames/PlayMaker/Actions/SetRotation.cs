using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Rotation of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	public class SetRotation : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Use a stored quaternion, or vector angles below.")]
		public FsmQuaternion quaternion;

		[Title("Euler Angles")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Use euler angles stored in a Vector3 variable, and/or set each axis below.")]
		public FsmVector3 vector;

		[Tooltip("Angle around the X axis in degrees.")]
		public FsmFloat xAngle;

		[Tooltip("Angle around the Y axis in degrees.")]
		public FsmFloat yAngle;

		[Tooltip("Angle around the Z axis in degrees.")]
		public FsmFloat zAngle;

		[Tooltip("Use local or world space.")]
		public Space space;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;

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

		private void DoSetRotation()
		{
		}
	}
}
