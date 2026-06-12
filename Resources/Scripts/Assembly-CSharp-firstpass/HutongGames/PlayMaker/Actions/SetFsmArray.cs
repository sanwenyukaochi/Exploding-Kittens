namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Copy an Array Variable in another FSM.")]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	public class SetFsmArray : BaseFsmVariableAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on Game Object.")]
		public FsmString fsmName;

		[RequiredField]
		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		[RequiredField]
		[Tooltip("Set the content of the array variable.")]
		[UIHint(UIHint.Variable)]
		public FsmArray setValue;

		[Tooltip("If true, makes copies. if false, values share the same reference and editing one array item value will affect the source and vice versa. Warning, this only affect the current items of the source array. Adding or removing items doesn't affect other FsmArrays.")]
		public bool copyValues;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetFsmArrayCopy()
		{
		}
	}
}
