namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns the index of a scene in the Build Settings. Always returns -1 if the scene was loaded through an AssetBundle.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneBuildIndex : GetSceneActionBase
	{
		[ActionSection("Result")]
		[Tooltip("The scene Build Index")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt buildIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetSceneBuildIndex()
		{
		}
	}
}
