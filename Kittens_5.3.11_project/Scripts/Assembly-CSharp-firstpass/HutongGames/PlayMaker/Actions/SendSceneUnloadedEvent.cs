using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Send an event when a scene was unloaded.")]
	public class SendSceneUnloadedEvent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The event to send when scene was unloaded")]
		public FsmEvent sceneUnloaded;

		public static Scene lastUnLoadedScene;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void SceneManager_sceneUnloaded(Scene scene)
		{
		}

		public override void OnExit()
		{
		}
	}
}
