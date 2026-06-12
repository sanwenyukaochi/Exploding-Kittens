using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Send event from a VideoPlayer after a seek operation completes..")]
	public class VideoPlayerSeekCompletedEvent : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("event invoked when the player preparation is complete.")]
		public FsmEvent OnSeekCompletedEvent;

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

		private void OnSeekCompleted(VideoPlayer source)
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
