using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Check whether current time can be changed using the time or timeFrames property on a VideoPlayer. (Read Only)")]
	public class VideoPlayerGetCanSetTime : FsmStateAction
	{
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Value")]
		[UIHint(UIHint.Variable)]
		public FsmBool canSetTime;

		[Tooltip("Event sent if time can be set")]
		public FsmEvent canSetTimeEvent;

		[Tooltip("Event sent if time can not be set")]
		public FsmEvent canNotSetTimeEvent;

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
