using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the RenderTexture to draw to when VideoPlayer.renderMode is set to Video.VideoTarget.RenderTexture.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerGetTargetTexture : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The RenderTexture")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmTexture targetTexture;

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
