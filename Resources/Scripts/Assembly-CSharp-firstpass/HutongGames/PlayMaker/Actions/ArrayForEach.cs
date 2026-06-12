namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Loop through all items in an {{Array}} and run an FSM Template on each item.\\nNOTE: This is an advanced/experimental action, still in beta. Please report any issues you run into.")]
	[ActionCategory(ActionCategory.Array)]
	public class ArrayForEach : RunFSMAction
	{
		[RequiredField]
		[Tooltip("Array to iterate through.")]
		[UIHint(UIHint.Variable)]
		public FsmArray array;

		[Tooltip("Store the item in a variable")]
		[UIHint(UIHint.Variable)]
		[MatchElementType("array")]
		[HideTypeFilter]
		public FsmVar storeItem;

		[Tooltip("The Template to run on each item in the array.<ul><li>The Template should expose a variable in the Inspector.</li><li>Use this Input variable to input the stored item.</li><li>The Template should use {{Finish FSM}} when finished.</li></ul>")]
		[ActionSection("Run FSM")]
		public FsmTemplateControl fsmTemplateControl;

		[Tooltip("Event to send after iterating through all items in the Array.")]
		public FsmEvent finishEvent;

		private int currentIndex;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void StartNextFsm()
		{
		}

		private void StartFsm()
		{
		}

		private void DoStartFsm()
		{
		}

		protected override void CheckIfFinished()
		{
		}
	}
}
