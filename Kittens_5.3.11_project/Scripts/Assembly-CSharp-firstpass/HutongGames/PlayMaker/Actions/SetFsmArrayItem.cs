namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Set an item in an Array Variable in another FSM.")]
	public class SetFsmArrayItem : BaseFsmVariableIndexAction
	{
		[Tooltip("The GameObject that owns the FSM.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object.")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		[RequiredField]
		public FsmString variableName;

		[Tooltip("The index into the array.")]
		public FsmInt index;

		[Tooltip("Set the value of the array at the specified index.")]
		[RequiredField]
		public FsmVar value;

		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetFsmArray()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
