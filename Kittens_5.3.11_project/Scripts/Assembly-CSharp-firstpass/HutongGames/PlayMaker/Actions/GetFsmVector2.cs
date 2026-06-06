using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the value of a Vector2 Variable from another FSM.")]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetFsmVector2 : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		[Tooltip("The name of the FSM variable to get.")]
		[UIHint(UIHint.FsmVector2)]
		[RequiredField]
		public FsmString variableName;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value in a Vector2 variable in this FSM.")]
		[RequiredField]
		public FsmVector2 storeValue;

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

		private void DoGetFsmVector2()
		{
		}
	}
}
