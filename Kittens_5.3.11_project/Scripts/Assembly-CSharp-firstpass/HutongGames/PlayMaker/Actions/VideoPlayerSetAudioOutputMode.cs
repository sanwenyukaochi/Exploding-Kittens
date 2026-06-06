using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Defines Destination for the audio embedded in the video.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerSetAudioOutputMode : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(VideoAudioOutputMode))]
		[Tooltip("The AudioOutputMode type")]
		[RequiredField]
		public FsmEnum audioOutputMode;

		private GameObject go;

		private VideoPlayer _vp;

		public override void Reset()
		{
		}

		public override void OnEnter()
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
