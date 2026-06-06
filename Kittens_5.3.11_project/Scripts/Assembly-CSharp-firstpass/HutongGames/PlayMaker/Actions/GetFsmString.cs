using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a String Variable from another FSM.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetFsmString : FsmStateAction
	{
		[Tooltip("The GameObject that owns the FSM.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[Tooltip("The name of the FSM variable to get.")]
		[UIHint(UIHint.FsmString)]
		[RequiredField]
		public FsmString variableName;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("Store the value in a String variable in this FSM.")]
		public FsmString storeValue;

		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		private GameObject goLastFrame;

		private string fsmNameLastFrame;

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

		private void DoGetFsmString()
		{
		}
	}
}
