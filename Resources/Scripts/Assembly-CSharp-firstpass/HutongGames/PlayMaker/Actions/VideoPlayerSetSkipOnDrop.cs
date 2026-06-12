using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set whether the player is allowed to skips frames to catch up with current time.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerSetSkipOnDrop : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Value")]
		[RequiredField]
		public FsmBool skipOnDrop;

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
