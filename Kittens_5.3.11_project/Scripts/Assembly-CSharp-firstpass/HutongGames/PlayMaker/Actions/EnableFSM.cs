namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Enables/Disables an FSM component on a GameObject.")]
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	public class EnableFSM : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the FSM component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.FsmName)]
		[Tooltip("Optional name of FSM on GameObject. Useful if you have more than one FSM on a GameObject. Leave blank to use the first FSM on the game object.")]
		public FsmString fsmName;

		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enable;

		[Tooltip("Reset the initial enabled state when exiting the state.")]
		public FsmBool resetOnExit;

		private PlayMakerFSM fsmComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoEnableFSM()
		{
		}

		public override void OnExit()
		{
		}
	}
}
