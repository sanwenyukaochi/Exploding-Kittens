using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Unload a scene asynchronously by its name or index in Build Settings. Destroys all GameObjects associated with the given scene and removes the scene from the SceneManager.")]
	public class UnloadSceneAsynch : FsmStateAction
	{
		public enum SceneReferenceOptions
		{
			ActiveScene = 0,
			SceneAtBuildIndex = 1,
			SceneAtIndex = 2,
			SceneByName = 3,
			SceneByPath = 4,
			SceneByGameObject = 5
		}

		[Tooltip("The reference options of the Scene")]
		public SceneReferenceOptions sceneReference;

		[Tooltip("The name of the scene to load. The given sceneName can either be the last part of the path, without .unity extension or the full path still without the .unity extension")]
		public FsmString sceneByName;

		[Tooltip("The build index of the scene to unload.")]
		public FsmInt sceneAtBuildIndex;

		[Tooltip("The index of the scene to unload.")]
		public FsmInt sceneAtIndex;

		[Tooltip("The scene Path.")]
		public FsmString sceneByPath;

		[Tooltip("The GameObject unload scene of")]
		public FsmOwnerDefault sceneByGameObject;

		[Tooltip("lets you tweak in which order async operation calls will be performed. Leave to none for default")]
		public FsmInt operationPriority;

		[Tooltip("The loading's progress.")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmFloat progress;

		[UIHint(UIHint.Variable)]
		[Tooltip("True when loading is done")]
		public FsmBool isDone;

		[Tooltip("Event sent when scene loading is done")]
		public FsmEvent doneEvent;

		[Tooltip("Event sent if the scene to load was not found")]
		public FsmEvent sceneNotFoundEvent;

		private AsyncOperation _asyncOperation;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private bool DoUnLoadAsynch()
		{
			return false;
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}
	}
}
