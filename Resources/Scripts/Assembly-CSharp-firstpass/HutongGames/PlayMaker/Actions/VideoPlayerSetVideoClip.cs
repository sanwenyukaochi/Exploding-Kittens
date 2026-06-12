using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Sets the VideoClip of a VideoPlayer.")]
	public class VideoPlayerSetVideoClip : FsmStateAction
	{
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(VideoClip))]
		[Tooltip("The VideoClip.")]
		public FsmObject videoClip;

		private GameObject go;

		private VideoPlayer _vp;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void GetVideoPlayer()
		{
		}
	}
}
