using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the value of a variable in another FSM.")]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SetFsmVariable : FsmStateAction
	{
		[Tooltip("The GameObject that owns the FSM")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object")]
		public FsmString fsmName;

		[Tooltip("The name of the variable in the target FSM.")]
		public FsmString variableName;

		[RequiredField]
		[Tooltip("Set the value.")]
		public FsmVar setValue;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private PlayMakerFSM targetFsm;

		private NamedVariable targetVariable;

		private GameObject cachedGameObject;

		private string cachedFsmName;

		private string cachedVariableName;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetFsmVariable()
		{
		}
	}
}
