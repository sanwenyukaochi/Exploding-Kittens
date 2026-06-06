using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Translates a Game Object's RigidBody2d. Unlike Translate2d this will respect physics collisions.")]
	[ActionCategory(ActionCategory.Physics)]
	public class TranslatePosition2d : ComponentAction<Rigidbody2D>
	{
		[Tooltip("The GameObject to move.")]
		[RequiredField]
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

		private void DoTranslatePosition2d()
		{
		}
	}
}
