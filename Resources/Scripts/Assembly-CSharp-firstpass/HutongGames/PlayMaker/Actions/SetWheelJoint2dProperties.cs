using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the various properties of a WheelJoint2d component")]
	public class SetWheelJoint2dProperties : FsmStateAction
	{
		[Tooltip("The WheelJoint2d target")]
		[CheckForComponent(typeof(WheelJoint2D))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[ActionSection("Motor")]
		[Tooltip("Should a motor force be applied automatically to the Rigidbody2D?")]
		public FsmBool useMotor;

		[Tooltip("The desired speed for the Rigidbody2D to reach as it moves with the joint.")]
		public FsmFloat motorSpeed;

		[Tooltip("The maximum force that can be applied to the Rigidbody2D at the joint to attain the target speed.")]
		public FsmFloat maxMotorTorque;

		[ActionSection("Suspension")]
		[Tooltip("The world angle along which the suspension will move. This provides 2D constrained motion similar to a SliderJoint2D. This is typically how suspension works in the real world.")]
		public FsmFloat angle;

		[Tooltip("The amount by which the suspension spring force is reduced in proportion to the movement speed.")]
		public FsmFloat dampingRatio;

		[Tooltip("The frequency at which the suspension spring oscillates.")]
		public FsmFloat frequency;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private WheelJoint2D _wj2d;

		private JointMotor2D _motor;

		private JointSuspension2D _suspension;

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
