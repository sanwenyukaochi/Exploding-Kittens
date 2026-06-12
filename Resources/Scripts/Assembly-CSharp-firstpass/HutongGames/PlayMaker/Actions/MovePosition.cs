using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Moves a Game Object's Rigid Body to a new position. Unlike Set Position this will respect physics collisions.")]
	[ActionCategory(ActionCategory.Physics)]
	public class MovePosition : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject to move.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Movement vector.")]
		public FsmVector3 vector;

		[Tooltip("Movement in x axis.")]
		public FsmFloat x;

		[Tooltip("Movement in y axis.")]
		public FsmFloat y;

		[Tooltip("Movement in z axis.")]
		public FsmFloat z;

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
