using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the various properties of a HingeJoint2d component")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class SetHingeJoint2dProperties : FsmStateAction
	{
		[CheckForComponent(typeof(HingeJoint2D))]
		[RequiredField]
		[Tooltip("The HingeJoint2d target")]
		public FsmOwnerDefault gameObject;

		[ActionSection("Limits")]
		[Tooltip("Should limits be placed on the range of rotation?")]
		public FsmBool useLimits;

		[Tooltip("Lower angular limit of rotation.")]
		public FsmFloat min;

		[Tooltip("Upper angular limit of rotation")]
		public FsmFloat max;

		[ActionSection("Motor")]
		[Tooltip("Should a motor force be applied automatically to the Rigidbody2D?")]
		public FsmBool useMotor;

		[Tooltip("The desired speed for the Rigidbody2D to reach as it moves with the joint.")]
		public FsmFloat motorSpeed;

		[Tooltip("The maximum force that can be applied to the Rigidbody2D at the joint to attain the target speed.")]
		public FsmFloat maxMotorTorque;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private HingeJoint2D _joint;

		private JointMotor2D _motor;

		private JointAngleLimits2D _limits;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void SetProperties()
		{
		}
	}
}
