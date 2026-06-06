namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a scene isDirty flag. True if the scene is modified.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneIsDirty : GetSceneActionBase
	{
		[ActionSection("Result")]
		[Tooltip("true if the scene is modified.")]
		[UIHint(UIHint.Variable)]
		public FsmBool isDirty;

		[Tooltip("Event sent if the scene is modified.")]
		public FsmEvent isDirtyEvent;

		[Tooltip("Event sent if the scene is unmodified.")]
		public FsmEvent isNotDirtyEvent;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetSceneIsDirty()
		{
		}
	}
}
