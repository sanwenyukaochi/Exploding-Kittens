namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Get a scene isDirty flag. true if the scene is modified. ")]
	public class GetSceneProperties : GetSceneActionBase
	{
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The scene name")]
		public FsmString name;

		[Tooltip("The scene path")]
		[UIHint(UIHint.Variable)]
		public FsmString path;

		[Tooltip("The scene Build Index")]
		[UIHint(UIHint.Variable)]
		public FsmInt buildIndex;

		[Tooltip("true if the scene is valid.")]
		[UIHint(UIHint.Variable)]
		public FsmBool isValid;

		[Tooltip("true if the scene is loaded.")]
		[UIHint(UIHint.Variable)]
		public FsmBool isLoaded;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the scene is modified.")]
		public FsmBool isDirty;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene RootCount")]
		public FsmInt rootCount;

		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[UIHint(UIHint.Variable)]
		[Tooltip("The scene Root GameObjects")]
		public FsmArray rootGameObjects;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetSceneProperties()
		{
		}
	}
}
