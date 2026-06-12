using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	public abstract class BaseFsmVariableIndexAction : FsmStateAction
	{
		[Tooltip("The event to trigger if the index is out of range")]
		[ActionSection("Events")]
		public FsmEvent indexOutOfRange;

		[Tooltip("The event to send if the FSM is not found.")]
		public FsmEvent fsmNotFound;

		[Tooltip("The event to send if the Variable is not found.")]
		public FsmEvent variableNotFound;

		private GameObject cachedGameObject;

		private string cachedFsmName;

		protected PlayMakerFSM fsm;

		public override void Reset()
		{
		}

		protected bool UpdateCache(GameObject go, string fsmName)
		{
			return false;
		}

		protected void DoVariableNotFound(string variableName)
		{
		}
	}
}
