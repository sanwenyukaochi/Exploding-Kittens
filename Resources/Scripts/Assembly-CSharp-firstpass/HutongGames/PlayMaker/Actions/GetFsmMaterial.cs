using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the value of a Material Variable from another FSM.")]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetFsmMaterial : FsmStateAction
	{
		[Tooltip("The GameObject that owns the FSM.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		[RequiredField]
		[Tooltip("The name of the FSM variable to get.")]
		[UIHint(UIHint.FsmMaterial)]
		public FsmString variableName;

		[Tooltip("Store the value in a Material variable in this FSM.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmMaterial storeValue;

		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		private GameObject goLastFrame;

		private string fsmNameLastFrame;

		protected PlayMakerFSM fsm;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetFsmVariable()
		{
		}
	}
}
