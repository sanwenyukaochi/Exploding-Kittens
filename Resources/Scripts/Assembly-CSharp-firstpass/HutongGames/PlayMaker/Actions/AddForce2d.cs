using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Adds a 2d force to a Game Object. Use Vector2 variable and/or Float variables for each axis.")]
	[SeeAlso("To add a force in local space use {{Add Relative Force 2d}}")]
	public class AddForce2d : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to apply the force to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Option for applying the force")]
		public ForceMode2D forceMode;

		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally apply the force at a position on the object. This will also add some torque. The position is often returned from MousePick or GetCollision2dInfo actions.")]
		public FsmVector2 atPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("A Vector2 force to add. Optionally override any axis with the X, Y parameters.")]
		public FsmVector2 vector;

		[Tooltip("Force along the X axis. To leave unchanged, set to 'None'.")]
		public FsmFloat x;

		[Tooltip("Force along the Y axis. To leave unchanged, set to 'None'.")]
		public FsmFloat y;

		[Tooltip("A Vector3 force to add. z is ignored")]
		public FsmVector3 vector3;

		[Tooltip("Repeat every frame while the state is active.")]
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

		private void DoAddForce()
		{
		}
	}
}
