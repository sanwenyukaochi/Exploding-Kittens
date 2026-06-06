using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Set the Material texture property which is targeted when VideoPlayer.renderMode is set to Video.VideoTarget.MaterialOverride.")]
	public class VideoPlayerSetTargetMaterialProperty : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Material texture property")]
		[RequiredField]
		public FsmString property;

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
