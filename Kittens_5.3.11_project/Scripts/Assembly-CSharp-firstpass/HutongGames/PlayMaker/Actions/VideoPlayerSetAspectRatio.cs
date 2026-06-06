using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Defines how the video content will be stretched to fill the target area.")]
	public class VideoPlayerSetAspectRatio : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(VideoAspectRatio))]
		[RequiredField]
		[Tooltip("The AspectRatio type")]
		public FsmEnum aspectRatio;

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
