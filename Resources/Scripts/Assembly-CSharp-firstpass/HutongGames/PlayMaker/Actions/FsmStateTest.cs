using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Tests if an FSM is in the specified State.")]
	public class FsmStateTest : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmGameObject gameObject;

		[Tooltip("Optional name of Fsm on Game Object. Useful if there is more than one FSM on the GameObject.")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[Tooltip("Check to see if the FSM is in this state.")]
		[RequiredField]
		public FsmString stateName;

		[Tooltip("Event to send if the FSM is in the specified state.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the FSM is NOT in the specified state.")]
		public FsmEvent falseEvent;

		[Tooltip("Store the result of this test in a bool variable. Useful if other actions depend on this test.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame. Useful if you want to wait for an FSM to be in a particular state before sending an event.")]
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

		private void DoFsmStateTest()
		{
		}
	}
}
