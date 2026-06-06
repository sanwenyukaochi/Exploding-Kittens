using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Send an event when a scene was loaded. Use the Safe version when you want to access content of the loaded scene. Use GetSceneloadedEventData to find out about the loaded Scene and load mode")]
	[ActionCategory(ActionCategory.Scene)]
	public class SendSceneLoadedEvent : FsmStateAction
	{
		[Tooltip("The event to send when a scene was loaded")]
		public FsmEvent sceneLoaded;

		[Tooltip("The event to send when a scene was loaded, with a one frame delay to make sure the scene content was indeed initialized fully")]
		public FsmEvent sceneLoadedSafe;

		public static Scene lastLoadedScene;

		public static LoadSceneMode lastLoadedMode;

		private int _loaded;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void SceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
