namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the number of scenes in Build Settings.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneCountInBuildSettings : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The number of scenes in Build Settings.")]
		public FsmInt sceneCountInBuildSettings;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetSceneCountInBuildSettings()
		{
		}
	}
}
