using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Check whether the player will wait for the first frame to be loaded into the texture before starting playback when VideoPlayer.playOnAwake is on")]
	public class VideoPlayerGetWaitForFirstFrame : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Value")]
		[UIHint(UIHint.Variable)]
		public FsmBool isWaitingForFirstFrame;

		[Tooltip("Event sent if content will wait for first frame")]
		public FsmEvent isWaitingForFirstFrameEvent;

		[Tooltip("Event sent if content will not wait for first frame")]
		public FsmEvent isNotWaitingForFirstFrameEvent;

		[Tooltip("Execute action everyframe. Events are however sent discretly, only when changes occurs")]
		public bool everyframe;

		private GameObject go;

		private VideoPlayer _vp;

		private int _isWaitingForFirstFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void ExecuteAction()
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
