using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets the 2d Velocity of a Game Object and stores it in a Vector2 Variable or each Axis in a Float Variable. NOTE: The Game Object must have a Rigid Body 2D.")]
	public class GetVelocity2d : ComponentAction<Rigidbody2D>
	{
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		[CheckForComponent(typeof(Rigidbody2D))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The velocity")]
		public FsmVector2 vector;

		[UIHint(UIHint.Variable)]
		[Tooltip("The x value of the velocity")]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("The y value of the velocity")]
		public FsmFloat y;

		[Tooltip("The space reference to express the velocity")]
		public Space space;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetVelocity()
		{
		}
	}
}
