namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	[Tooltip("Gets an item in an Array Variable in another FSM.")]
	public class GetFsmArrayItem : BaseFsmVariableIndexAction
	{
		[Tooltip("The GameObject that owns the FSM.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Optional name of FSM on Game Object.")]
		[UIHint(UIHint.FsmName)]
		public FsmString fsmName;

		[RequiredField]
		[UIHint(UIHint.FsmArray)]
		[Tooltip("The name of the FSM variable.")]
		public FsmString variableName;

		[Tooltip("The index into the array.")]
		public FsmInt index;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the value of the array at the specified index.")]
		public FsmVar storeValue;

		[Tooltip("Repeat every frame. Useful if the value is changing.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetFsmArray()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
