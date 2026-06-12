using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the 2d Velocity of a Game Object. To leave any axis unchanged, set variable to 'None'. NOTE: Game object must have a rigidbody 2D.")]
	public class SetVelocity2d : ComponentAction<Rigidbody2D>
	{
		[CheckForComponent(typeof(Rigidbody2D))]
		[RequiredField]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Use a Vector2 value for the velocity and/or set individual axis below. If set to None, keeps current velocity.")]
		public FsmVector2 vector;

		[Tooltip("Set the x value of the velocity. If None keep current x velocity.")]
		public FsmFloat x;

		[Tooltip("Set the y value of the velocity. If None keep current y velocity.")]
		public FsmFloat y;

		[Tooltip("Set velocity in local or word space.")]
		public Space space;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoSetVelocity()
		{
		}
	}
}
