using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Collision Flags from a CharacterController on a GameObject. Collision flags give you a broad overview of where the character collided with another object.")]
	[ActionCategory(ActionCategory.Character)]
	public class GetControllerCollisionFlags : ComponentAction<CharacterController>
	{
		[Tooltip("The GameObject with a Character Controller component.")]
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		public FsmOwnerDefault gameObject;

		[Tooltip("True if the Character Controller capsule is on the ground")]
		[UIHint(UIHint.Variable)]
		public FsmBool isGrounded;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if no collisions in last move.")]
		public FsmBool none;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule was hit on the sides.")]
		public FsmBool sides;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule was hit from above.")]
		public FsmBool above;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if the Character Controller capsule was hit from below.")]
		public FsmBool below;

		private CharacterController controller => null;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
