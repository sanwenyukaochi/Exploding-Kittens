namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a scene path.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetScenePath : GetSceneActionBase
	{
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The scene path")]
		[RequiredField]
		public FsmString path;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetScenePath()
		{
		}
	}
}
