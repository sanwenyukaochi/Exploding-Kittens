namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the total number of currently loaded scenes.")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneCount : FsmStateAction
	{
		[Tooltip("The number of currently loaded scenes.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmInt sceneCount;

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

		private void DoGetSceneCount()
		{
		}
	}
}
