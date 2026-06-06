using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Check Whether the player restarts from the beginning without when it reaches the end of the clip.")]
	public class VideoPlayerGetIsLooping : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Value")]
		public FsmBool isLooping;

		[Tooltip("Event sent if content is looping")]
		public FsmEvent isLoopingEvent;

		[Tooltip("Event sent if content is not looping")]
		public FsmEvent isNotLoopingEvent;

		[Tooltip("Execute action everyframe. Events are however sent discretly, only when changes occurs")]
		public bool everyframe;

		private GameObject go;

		private VideoPlayer _vp;

		private int _isLooping;

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
