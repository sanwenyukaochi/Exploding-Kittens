namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a scene isValid flag. A scene may be invalid if, for example, you tried to open a scene that does not exist. In this case, the scene returned from EditorSceneManager.OpenScene would return False for IsValid. ")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneIsValid : GetSceneActionBase
	{
		[Tooltip("true if the scene is loaded.")]
		[UIHint(UIHint.Variable)]
		[ActionSection("Result")]
		public FsmBool isValid;

		[Tooltip("Event sent if the scene is valid.")]
		public FsmEvent isValidEvent;

		[Tooltip("Event sent if the scene is not valid.")]
		public FsmEvent isNotValidEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetSceneIsValid()
		{
		}
	}
}
