using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check whether it's possible to set if the player can skips frames to catch up with current time. (Read Only)")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerGetCanSkipOnDrop : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Value")]
		public FsmBool canSetSkipOnDrop;

		[Tooltip("Event sent if SkipOnDrop can be set")]
		public FsmEvent canSetSkipOnDropEvent;

		[Tooltip("Event sent if SkipOnDrop can not be set")]
		public FsmEvent canNotSetSkipOnDropEvent;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private int _canSetSkipOnDrop;

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
