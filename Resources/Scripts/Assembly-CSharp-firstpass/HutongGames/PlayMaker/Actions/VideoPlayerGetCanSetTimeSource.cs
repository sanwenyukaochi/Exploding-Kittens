using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check whether the time source followed by the video player can be changed. (Read Only)")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerGetCanSetTimeSource : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Value")]
		[UIHint(UIHint.Variable)]
		public FsmBool canSetTimeSource;

		[Tooltip("Event sent if timeSource can be set")]
		public FsmEvent canSetTimeSourceEvent;

		[Tooltip("Event sent if timeSource can not be set")]
		public FsmEvent canNotSetTimeSourceEvent;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject go;

		private VideoPlayer _vp;

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
