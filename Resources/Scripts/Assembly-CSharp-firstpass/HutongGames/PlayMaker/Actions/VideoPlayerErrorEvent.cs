using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Send error event from a VideoPlayer.")]
	public class VideoPlayerErrorEvent : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("event sent when VideoPlayer throws an error")]
		public FsmEvent onErrorEvent;

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

		private void OnErrorReceived(VideoPlayer source, string errorMessage)
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
