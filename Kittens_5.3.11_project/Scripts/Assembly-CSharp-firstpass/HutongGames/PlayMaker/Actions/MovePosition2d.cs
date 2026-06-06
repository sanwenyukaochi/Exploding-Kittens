using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Moves a Game Object's RigidBody2D to a new position. Unlike SetPosition this will respect physics collisions.")]
	public class MovePosition2d : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[Tooltip("The GameObject to move.")]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Movement vector.")]
		public FsmVector2 vector;

		[Tooltip("Movement in x axis.")]
		public FsmFloat x;

		[Tooltip("Movement in y axis.")]
		public FsmFloat y;

		[Tooltip("Coordinate space to move in.")]
		public Space space;

		[Tooltip("Keep running every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoMovePosition()
		{
		}
	}
}
