using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Set the value of multi in Pair Integer Variable in another FSM.")]
	public class SetFsmIntMulti : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[RequiredField]
		[Tooltip("The name of the FSM variable.")]
		[CompoundArray("How Many INT", "variable Name", "Set INT")]
		[UIHint(UIHint.FsmInt)]
		public FsmString[] variableName;

		[RequiredField]
		[Tooltip("Set the value of the variable.")]
		public FsmInt[] setValue;

		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		private GameObject goLastFrame;

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

		private void DoSetFsmInt()
		{
		}
	}
}
