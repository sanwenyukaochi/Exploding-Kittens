using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Loads the scene by its name or index in Build Settings. ")]
	[ActionCategory(ActionCategory.Scene)]
	public class LoadScene : FsmStateAction
	{
		[Tooltip("The reference options of the Scene")]
		public GetSceneActionBase.SceneSimpleReferenceOptions sceneReference;

		[Tooltip("The name of the scene to load. The given sceneName can either be the last part of the path, without .unity extension or the full path still without the .unity extension")]
		public FsmString sceneByName;

		[Tooltip("The index of the scene to load.")]
		public FsmInt sceneAtIndex;

		[Tooltip("Allows you to specify whether or not to load the scene additively. See LoadSceneMode Unity doc for more information about the options.")]
		[ObjectType(typeof(LoadSceneMode))]
		public FsmEnum loadSceneMode;

		[Tooltip("True if the scene was loaded")]
		[ActionSection("Result")]
		public FsmBool success;

		[Tooltip("Event sent if the scene was loaded")]
		public FsmEvent successEvent;

		[Tooltip("Event sent if a problem occurred, check log for information")]
		public FsmEvent failureEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private bool DoLoadScene()
		{
			return false;
		}
	}
}
