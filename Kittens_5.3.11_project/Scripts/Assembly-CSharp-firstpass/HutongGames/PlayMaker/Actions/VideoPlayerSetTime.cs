using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Sets the time value of a VideoPlayer.")]
	public class VideoPlayerSetTime : FsmStateAction
	{
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The time Value")]
		[RequiredField]
		public FsmFloat time;

		[Tooltip("Event sent if time can not be set")]
		public FsmEvent canNotSetTime;

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
