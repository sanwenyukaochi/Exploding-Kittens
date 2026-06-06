using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the Rotation of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable")]
	public class GetRotation : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the rotation as a Quaternion.")]
		public FsmQuaternion quaternion;

		[UIHint(UIHint.Variable)]
		[Title("Euler Angles")]
		[Tooltip("Get the rotation as Euler angles (rotation around each axis) and store in a Vector3 Variable.")]
		public FsmVector3 vector;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the angle around the X axis.")]
		public FsmFloat xAngle;

		[Tooltip("Get the angle around the Y axis.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat yAngle;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the angle around the Z axis.")]
		public FsmFloat zAngle;

		[Tooltip("The coordinate space to get the rotation in.")]
		public Space space;

		[Tooltip("Repeat every frame")]
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

		private void DoGetRotation()
		{
		}
	}
}
