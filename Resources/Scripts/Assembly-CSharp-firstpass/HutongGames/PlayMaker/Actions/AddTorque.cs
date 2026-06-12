using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Adds torque (rotational force) to a Game Object. NOTE: The game object requires a Rigid Body.")]
	public class AddTorque : ComponentAction<Rigidbody>
	{
		[CheckForComponent(typeof(Rigidbody))]
		[RequiredField]
		[Tooltip("The GameObject to add torque (rotational force) to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("A Vector3 torque. Optionally override any axis with the X, Y, Z parameters.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[Tooltip("Torque around the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		[Tooltip("Torque around the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		[Tooltip("Torque around the Z axis. To leave unchanged, set to 'None'.")]
		public FsmFloat z;

		[Tooltip("Apply the force in world or local space.")]
		public Space space;

		[Tooltip("The type of force to apply. See Unity Physics docs.")]
		public ForceMode forceMode;

		[Tooltip("Apply the force every frame that the State is active.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoAddTorque()
		{
		}
	}
}
