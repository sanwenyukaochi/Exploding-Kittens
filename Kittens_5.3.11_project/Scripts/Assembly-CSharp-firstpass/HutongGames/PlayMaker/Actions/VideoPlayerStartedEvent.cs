using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Send the started event from a VideoPlayer.")]
	public class VideoPlayerStartedEvent : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("event sent when VideoPlayer started")]
		public FsmEvent onStartedEvent;

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

		private void OnStarted(VideoPlayer source)
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
