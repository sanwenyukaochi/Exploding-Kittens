using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Advances the current time by one frame immediately of a VideoPlayer.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerStepForward : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[RequiredField]
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
