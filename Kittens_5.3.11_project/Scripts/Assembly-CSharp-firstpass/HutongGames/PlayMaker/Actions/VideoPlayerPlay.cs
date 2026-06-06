using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Starts playback of a VideoPlayer. Initiates the preparation if not already done, in which case the playback will not start instantly.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerPlay : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

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
