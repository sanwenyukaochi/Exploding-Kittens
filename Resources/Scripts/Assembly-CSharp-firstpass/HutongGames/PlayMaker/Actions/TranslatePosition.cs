using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Translates a Game Object's RigidBody. Unlike Translate this will respect physics collisions.")]
	[ActionCategory(ActionCategory.Physics)]
	public class TranslatePosition : ComponentAction<Rigidbody>
	{
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject to move.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Movement vector.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[Tooltip("Movement in x axis.")]
		public FsmFloat x;

		[Tooltip("Movement in y axis.")]
		public FsmFloat y;

		[Tooltip("Movement in z axis.")]
		public FsmFloat z;

		[Tooltip("Coordinate space to move in.")]
		public Space space;

		[Tooltip("Translate over one second")]
		public bool perSecond;

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
