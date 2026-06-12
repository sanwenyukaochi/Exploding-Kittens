using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a relative 2d force to a Game Object. Use Vector2 variable and/or Float variables for each axis.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class AddRelativeForce2d : ComponentAction<Rigidbody2D>
	{
		[Tooltip("The GameObject to apply the force to.")]
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Option for applying the force")]
		public ForceMode2D forceMode;

		[Tooltip("A Vector2 force to add. Optionally override any axis with the X, Y parameters.")]
		[UIHint(UIHint.Variable)]
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

		private void DoAddRelativeForce()
		{
		}
	}
}
