using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if an FSM has a variable with the given name.")]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[ActionCategory(ActionCategory.Logic)]
	public class FsmHasVariable : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmGameObject gameObject;

		[Tooltip("Optional name of Fsm on Game Object. Useful if there is more than one FSM on the GameObject.")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[Tooltip("Check to see if the FSM has this variable.")]
		[RequiredField]
		public FsmString variableName;

		[Tooltip("Event to send if the FSM has the variable.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the FSM does NOT have the variable.")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result of this test in a bool variable. Useful if other actions depend on this test.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame. Useful if you're waiting for a particular result.")]
		public bool everyFrame;

		private GameObject previousGo;

		private PlayMakerFSM fsm;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoFsmVariableTest()
		{
		}
	}
}
