using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Send an event when the active scene has changed.")]
	public class SendActiveSceneChangedEvent : FsmStateAction
	{
		[Tooltip("The event to send when an active scene changed")]
		[RequiredField]
		public FsmEvent activeSceneChanged;

		public static Scene lastPreviousActiveScene;

		public static Scene lastNewActiveScene;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void SceneManager_activeSceneChanged(Scene previousActiveScene, Scene activeScene)
		{
		}

		public override void OnExit()
		{
		}
	}
}
