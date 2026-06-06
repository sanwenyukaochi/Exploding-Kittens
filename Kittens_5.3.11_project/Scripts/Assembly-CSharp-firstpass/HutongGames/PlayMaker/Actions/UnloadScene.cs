using System;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Unload Scene. Note that assets are currently not unloaded, in order to free up asset memory call Resources.UnloadUnusedAssets.")]
	[Obsolete("Use UnloadSceneAsynch Instead.")]
	public class UnloadScene : FsmStateAction
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

		[ActionSection("Result")]
		[Tooltip("True if scene was unloaded")]
		[UIHint(UIHint.Variable)]
		public FsmBool unloaded;

		[Tooltip("Event sent if scene was unloaded ")]
		public FsmEvent unloadedEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent scene was not unloaded")]
		public FsmEvent failureEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
