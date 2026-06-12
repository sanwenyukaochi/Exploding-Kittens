using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Get the value of a Color Variable from another FSM.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetFsmColor : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[RequiredField]
		[Tooltip("The name of the FSM variable to get.")]
		[UIHint(UIHint.FsmColor)]
		public FsmString variableName;

		[Tooltip("Store the value in a Color variable in this FSM.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmColor storeValue;

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

		private void DoGetFsmColor()
		{
		}
	}
}
