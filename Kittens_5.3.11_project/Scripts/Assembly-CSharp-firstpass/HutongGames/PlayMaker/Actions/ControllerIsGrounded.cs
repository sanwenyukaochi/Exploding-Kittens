using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Tests if a Character Controller on a Game Object was touching the ground during the last move.")]
	public class ControllerIsGrounded : ComponentAction<CharacterController>
	{
		[RequiredField]
		[CheckForComponent(typeof(CharacterController))]
		[Tooltip("The GameObject to check.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event to send if touching the ground.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if not touching the ground.")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private CharacterController controller => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoControllerIsGrounded()
		{
		}
	}
}
