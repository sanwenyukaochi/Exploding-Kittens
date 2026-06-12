using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Send the loopPointReached event from a VideoPlayer.")]
	public class VideoPlayerLoopPointReachedEvent : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("event invoked when the player reaches the end of the content to play.")]
		public FsmEvent OnLoopPointReachedEvent;

		private GameObject go;

		private VideoPlayer _vp;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void OnLoopPointReached(VideoPlayer source)
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
