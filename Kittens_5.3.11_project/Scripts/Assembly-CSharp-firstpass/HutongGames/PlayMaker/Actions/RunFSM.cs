namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Creates an FSM at runtime from a saved {{Template}}. The FSM is only active while the state is active. This lets you nest FSMs inside states.\nThis is a very powerful action! It allows you to create a library of FSM Templates that can be re-used in your project. You can edit the template in one place and the changes are reflected everywhere.\nNOTE: You can also specify a template in the {{FSM Inspector}}.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class RunFSM : RunFSMAction
	{
		[Tooltip("The Template to use. You can drag and drop, use the Unity object browser, or the categorized popup browser to select a template.")]
		public FsmTemplateControl fsmTemplateControl;

		[Tooltip("Event to send when the FSM has finished (usually because it ran a {{Finish FSM}} action).")]
		public FsmEvent finishEvent;

		[Tooltip("Repeat every frame. Waits for the sub Fsm to finish before calling it again.")]
		[ActionSection(null)]
		public bool everyFrame;

		private bool restart;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void OnOutputEvent(FsmEvent fsmEvent)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		public override bool Event(FsmEvent fsmEvent)
		{
			return false;
		}

		protected override void CheckIfFinished()
		{
		}
	}
}
