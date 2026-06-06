using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Moves a Game Object with a Character Controller. Velocity along the y-axis is ignored. Speed is in meters/s. Gravity is automatically applied.")]
	public class ControllerSimpleMove : ComponentAction<CharacterController>
	{
		[RequiredField]
		[Tooltip("A Game Object with a Character Controller.")]
		[CheckForComponent(typeof(CharacterController))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The movement vector.")]
		[RequiredField]
		public FsmVector3 moveVector;

		[Tooltip("Multiply the Move Vector by a speed factor.")]
		public FsmFloat speed;

		[Tooltip("Move in local or world space.")]
		public Space space;

		[Tooltip("Event sent if the Character Controller starts falling.")]
		public FsmEvent fallingEvent;

		private CharacterController controller => null;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
