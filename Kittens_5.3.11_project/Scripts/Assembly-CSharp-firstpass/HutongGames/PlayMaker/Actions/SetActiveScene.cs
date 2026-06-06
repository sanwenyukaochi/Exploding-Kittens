using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Set the scene to be active.")]
	public class SetActiveScene : FsmStateAction
	{
		public enum SceneReferenceOptions
		{
			SceneAtBuildIndex = 0,
			SceneAtIndex = 1,
			SceneByName = 2,
			SceneByPath = 3,
			SceneByGameObject = 4
		}

		[Tooltip("The reference options of the Scene.")]
		public SceneReferenceOptions sceneReference;

		[Tooltip("The name of the scene to activate. The given sceneName can either be the last part of the path, without .unity extension or the full path still without the .unity extension")]
		public FsmString sceneByName;

		[Tooltip("The build index of the scene to activate.")]
		public FsmInt sceneAtBuildIndex;

		[Tooltip("The index of the scene to activate.")]
		public FsmInt sceneAtIndex;

		[Tooltip("The scene Path.")]
		public FsmString sceneByPath;

		[Tooltip("The GameObject scene to activate.")]
		public FsmOwnerDefault sceneByGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if set active succeeded.")]
		[ActionSection("Result")]
		public FsmBool success;

		[Tooltip("Event sent if setActive succeeded.")]
		public FsmEvent successEvent;

		[Tooltip("True if SceneReference resolves to a scene.")]
		[UIHint(UIHint.Variable)]
		public FsmBool sceneFound;

		[Tooltip("Event sent if scene not activated yet.")]
		[UIHint(UIHint.Variable)]
		public FsmEvent sceneNotActivatedEvent;

		[Tooltip("Event sent if SceneReference do not resolve to a scene.")]
		public FsmEvent sceneNotFoundEvent;

		private Scene _scene;

		private bool _sceneFound;

		private bool _success;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetActivate()
		{
		}
	}
}
