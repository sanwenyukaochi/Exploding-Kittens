using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Send the framedropped event from a VideoPlayer when playback detects it does not keep up with the time source..")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerFrameDroppedEvent : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("event sent when playback detects it does not keep up with the time source.")]
		public FsmEvent onFrameDroppedEvent;

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

		private void OnFrameDropped(VideoPlayer source)
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
