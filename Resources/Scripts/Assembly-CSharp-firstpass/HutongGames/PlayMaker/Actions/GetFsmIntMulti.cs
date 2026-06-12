namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("multi Integer Variables from another FSM.")]
	[ActionCategory("Ngui Actions")]
	public class GetFsmIntMulti : FsmStateAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Name of FSM on Game Object, if you have more than one so this is important to get the right one")]
		public FsmString fsmName;

		[UIHint(UIHint.FsmInt)]
		[RequiredField]
		[CompoundArray("How Many INT", "variable Name", "Store INT")]
		public FsmString[] variableName;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmInt[] storeValue;

		public bool everyFrame;

		private PlayMakerFSM fsm;

		private FsmInt fsmInt;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetFsmInt()
		{
		}
	}
}
