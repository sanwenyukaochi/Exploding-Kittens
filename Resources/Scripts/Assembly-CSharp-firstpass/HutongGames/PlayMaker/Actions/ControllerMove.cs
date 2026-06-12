using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Moves a Game Object with a Character Controller. See also {{Controller Simple Move}}. NOTE: It is recommended that you make only one call to Move or SimpleMove per frame.")]
	[ActionCategory(ActionCategory.Character)]
	public class ControllerMove : FsmStateAction
	{
		[Tooltip("The Game Object that owns the Character Controller component.")]
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The movement vector.")]
		[RequiredField]
		public FsmVector3 moveVector;

		[Tooltip("Move in local or word space.")]
		public Space space;

		[Tooltip("Apply the move over one second. Makes movement frame rate independent.")]
		public FsmBool perSecond;

		private GameObject previousGo;

		private CharacterController controller;

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
