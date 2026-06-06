using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the value of a Vector3 Variable from another FSM.")]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetFsmVector3 : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[UIHint(UIHint.FsmVector3)]
		[RequiredField]
		[Tooltip("The name of the FSM variable to get.")]
		public FsmString variableName;

		[RequiredField]
		[Tooltip("Store the value in a Vector3 variable in this FSM.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeValue;

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

		private void DoGetFsmVector3()
		{
		}
	}
}
