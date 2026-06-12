using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(GameObject), "gameObject", false)]
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if a Game Object is visible to any camera.\nNOTE: In the editor this includes the Scene View camera!")]
	public class GameObjectIsVisible : ComponentAction<Renderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject to test.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event to send if the GameObject is visible.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the GameObject is NOT visible.")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		[Tooltip("Perform this action every frame.")]
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

		private void DoIsVisible()
		{
		}
	}
}
