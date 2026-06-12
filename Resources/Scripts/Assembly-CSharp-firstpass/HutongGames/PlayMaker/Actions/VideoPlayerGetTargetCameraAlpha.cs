using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Get the Overall transparency level of the target camera plane video.")]
	public class VideoPlayerGetTargetCameraAlpha : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The Overall transparency level")]
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
