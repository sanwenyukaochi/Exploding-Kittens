using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the last Unloaded Scene Event data when event was sent from the action 'SendSceneUnloadedEvent")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneUnloadedEventData : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The scene name")]
		public FsmString name;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene path")]
		public FsmString path;

		[Tooltip("The scene Build Index")]
		[UIHint(UIHint.Variable)]
		public FsmInt buildIndex;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the scene is valid.")]
		public FsmBool isValid;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the scene is loaded.")]
		public FsmBool isLoaded;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the scene is modified.")]
		public FsmBool isDirty;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene RootCount")]
		public FsmInt rootCount;

		[Tooltip("The scene Root GameObjects")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		public FsmArray rootGameObjects;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		private Scene _scene;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetSceneProperties()
		{
		}
	}
}
