namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Get a scene isLoaded flag.")]
	public class GetSceneIsLoaded : GetSceneActionBase
	{
		[Tooltip("true if the scene is loaded.")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmBool isLoaded;

		[Tooltip("Event sent if the scene is loaded.")]
		public FsmEvent isLoadedEvent;

		[Tooltip("Event sent if the scene is not loaded.")]
		public FsmEvent isNotLoadedEvent;

		[Tooltip("Repeat every Frame")]
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

		private void DoGetSceneIsLoaded()
		{
		}
	}
}
