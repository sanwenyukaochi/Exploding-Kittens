namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if a GameObject has children.")]
	[ActionCategory(ActionCategory.Logic)]
	public class GameObjectHasChildren : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to test.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event to send if the GameObject has children.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the GameObject does not have children.")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

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

		private void DoHasChildren()
		{
		}
	}
}
