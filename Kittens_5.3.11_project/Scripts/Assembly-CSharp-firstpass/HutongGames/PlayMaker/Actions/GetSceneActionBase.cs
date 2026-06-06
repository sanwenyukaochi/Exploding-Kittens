using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	public abstract class GetSceneActionBase : FsmStateAction
	{
		public enum SceneReferenceOptions
		{
			SceneAtIndex = 0,
			SceneByName = 1,
			SceneByPath = 2
		}

		public enum SceneSimpleReferenceOptions
		{
			SceneAtIndex = 0,
			SceneByName = 1
		}

		public enum SceneBuildReferenceOptions
		{
			SceneAtBuildIndex = 0,
			SceneByName = 1
		}

		public enum SceneAllReferenceOptions
		{
			ActiveScene = 0,
			SceneAtIndex = 1,
			SceneByName = 2,
			SceneByPath = 3,
			SceneByGameObject = 4
		}

		[Tooltip("The reference option of the Scene")]
		public SceneAllReferenceOptions sceneReference;

		[Tooltip("The scene Index.")]
		public FsmInt sceneAtIndex;

		[Tooltip("The scene Name.")]
		public FsmString sceneByName;

		[Tooltip("The scene Path.")]
		public FsmString sceneByPath;

		[Tooltip("The Scene of GameObject")]
		public FsmOwnerDefault sceneByGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if SceneReference resolves to a scene")]
		public FsmBool sceneFound;

		[Tooltip("Event sent if SceneReference resolves to a scene")]
		public FsmEvent sceneFoundEvent;

		[Tooltip("Event sent if SceneReference do not resolve to a scene")]
		public FsmEvent sceneNotFoundEvent;

		[Tooltip("The Scene Cache")]
		protected Scene _scene;

		[Tooltip("True if a scene was found, use _scene to access it")]
		protected bool _sceneFound;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
