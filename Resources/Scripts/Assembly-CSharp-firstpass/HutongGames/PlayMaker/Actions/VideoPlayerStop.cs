using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Stops playback of a VideoPlayer. Pauses the playback and sets the current time to 0.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerStop : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
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
