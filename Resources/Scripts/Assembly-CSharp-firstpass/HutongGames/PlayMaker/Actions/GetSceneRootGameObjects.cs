namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a scene Root GameObjects.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneRootGameObjects : GetSceneActionBase
	{
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[RequiredField]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The scene Root GameObjects")]
		public FsmArray rootGameObjects;

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

		private void DoGetSceneRootGameObjects()
		{
		}
	}
}
