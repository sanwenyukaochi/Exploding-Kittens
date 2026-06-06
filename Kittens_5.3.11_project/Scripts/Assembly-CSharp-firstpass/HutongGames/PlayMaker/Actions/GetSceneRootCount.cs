namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Get a scene RootCount, the number of root transforms of this scene.")]
	public class GetSceneRootCount : GetSceneActionBase
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[ActionSection("Result")]
		[Tooltip("The scene RootCount")]
		public FsmInt rootCount;

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

		private void DoGetSceneRootCount()
		{
		}
	}
}
