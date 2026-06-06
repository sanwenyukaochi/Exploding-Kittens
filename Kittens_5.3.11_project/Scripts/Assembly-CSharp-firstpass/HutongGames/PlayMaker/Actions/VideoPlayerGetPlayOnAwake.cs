using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check Whether the content will start playing back as soon as the component awakes.")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerGetPlayOnAwake : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Value")]
		public FsmBool isPlayingOnAwake;

		[Tooltip("Event sent if content content will start playing back as soon as the component awakes")]
		public FsmEvent isPlayingOnAwakeEvent;

		[Tooltip("Event sent if content will not start playing back as soon as the component awakes")]
		public FsmEvent isNotPlayingOnAwakeEvent;

		[Tooltip("Execute action everyframe. Events are however sent discretly, only when changes occurs")]
		public bool everyframe;

		private GameObject go;

		private VideoPlayer _vp;

		private int _isPlayingOnAwake;

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
