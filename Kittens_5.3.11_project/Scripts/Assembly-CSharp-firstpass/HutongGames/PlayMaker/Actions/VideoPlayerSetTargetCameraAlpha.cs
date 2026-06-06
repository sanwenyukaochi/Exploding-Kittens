using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Set the Overall transparency level of the target camera plane video.")]
	public class VideoPlayerSetTargetCameraAlpha : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Overall transparency level")]
		[RequiredField]
		public FsmFloat alpha;

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
