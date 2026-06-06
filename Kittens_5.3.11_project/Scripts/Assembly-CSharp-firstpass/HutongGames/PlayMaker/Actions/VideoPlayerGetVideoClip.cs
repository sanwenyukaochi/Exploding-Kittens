using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("the videoClip of a VideoPlayer.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerGetVideoClip : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The video clip of the VideoPlayer")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmObject videoClip;

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
