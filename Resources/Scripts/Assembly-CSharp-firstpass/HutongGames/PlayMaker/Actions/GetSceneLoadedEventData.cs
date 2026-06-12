using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the last Loaded Scene Event data when event was sent from the action 'SendSceneLoadedEvent")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneLoadedEventData : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The scene loaded mode")]
		[ObjectType(typeof(LoadSceneMode))]
		public FsmEnum loadedMode;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene name")]
		public FsmString name;

		[Tooltip("The scene path")]
		[UIHint(UIHint.Variable)]
		public FsmString path;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the scene is valid.")]
		public FsmBool isValid;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene Build Index")]
		public FsmInt buildIndex;

		[Tooltip("true if the scene is loaded.")]
		[UIHint(UIHint.Variable)]
		public FsmBool isLoaded;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the scene is modified.")]
		public FsmBool isDirty;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene RootCount")]
		public FsmInt rootCount;

		[UIHint(UIHint.Variable)]
		[Tooltip("The scene Root GameObjects")]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		public FsmArray rootGameObjects;

		private Scene _scene;

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
