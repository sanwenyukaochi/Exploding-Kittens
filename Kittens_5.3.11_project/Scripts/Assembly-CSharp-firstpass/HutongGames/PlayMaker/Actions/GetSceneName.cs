namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a scene name.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneName : GetSceneActionBase
	{
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("The scene name")]
		[UIHint(UIHint.Variable)]
		public FsmString name;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetSceneName()
		{
		}
	}
}
