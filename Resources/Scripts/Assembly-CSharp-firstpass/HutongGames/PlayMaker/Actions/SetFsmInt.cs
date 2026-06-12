using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set the value of an Integer Variable in another FSM.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SetFsmInt : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[Tooltip("The name of the FSM variable.")]
		[UIHint(UIHint.FsmInt)]
		[RequiredField]
		public FsmString variableName;

		[Tooltip("Set the value of the variable.")]
		[RequiredField]
		public FsmInt setValue;

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

		private void DoSetFsmInt()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
