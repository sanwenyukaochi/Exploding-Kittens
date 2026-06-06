using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Check whether the player is allowed to skips frames to catch up with current time.")]
	public class VideoPlayerGetSkipOnDrop : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject with a VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Value")]
		public FsmBool skipOnDrop;

		[Tooltip("Event sent if SkipOnDrop is true")]
		public FsmEvent doesSkipOnDropEvent;

		[Tooltip("Event sent if SkipOnDrop is false")]
		public FsmEvent DoNotSkipOnDropEvent;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private int _canSetSkipOnDrop;

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
