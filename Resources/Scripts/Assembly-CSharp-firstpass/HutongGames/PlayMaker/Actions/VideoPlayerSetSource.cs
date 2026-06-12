using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Set the video source type. It is valid to set both a VideoClip and a URL in the player. This property controls which one will get used for playback. When setting a new clip or URL, the source will automatically change to make the associated type current.")]
	public class VideoPlayerSetSource : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(VideoSource))]
		[RequiredField]
		[Tooltip("The source type")]
		public FsmEnum source;

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
