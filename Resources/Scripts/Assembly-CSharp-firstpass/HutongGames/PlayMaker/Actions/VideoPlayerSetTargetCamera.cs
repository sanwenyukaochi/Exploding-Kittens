using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Set The Camera GameObject to draw to when VideoPlayer.renderMode is set to either Video.VideoTarget.CameraBackPlane or Video.VideoTarget.CameraFrontPlane.")]
	public class VideoPlayerSetTargetCamera : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[CheckForComponent(typeof(Camera))]
		[RequiredField]
		[Tooltip("The Camera GameObject")]
		public FsmGameObject targetCamera;

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
