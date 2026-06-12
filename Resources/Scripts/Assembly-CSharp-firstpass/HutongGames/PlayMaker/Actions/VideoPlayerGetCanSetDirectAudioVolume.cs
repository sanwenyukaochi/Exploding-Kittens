using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Check whether direct-output volume controls are supported for the current platform and video format on a VideoPlayer. (Read Only)")]
	public class VideoPlayerGetCanSetDirectAudioVolume : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Value")]
		[UIHint(UIHint.Variable)]
		public FsmBool canSetDirectAudioVolume;

		[Tooltip("Event sent if DirectAudioVolume can be set")]
		public FsmEvent canSetDirectAudioVolumeEvent;

		[Tooltip("Event sent if DirectAudioVolume can not be set")]
		public FsmEvent canNotSetDirectAudioVolumeEvent;

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
