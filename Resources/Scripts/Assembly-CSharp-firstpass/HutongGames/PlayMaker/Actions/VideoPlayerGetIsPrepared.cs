using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Check Whether the player has successfully prepared the content to be played. (Read Only)")]
	[ActionCategory(ActionCategory.Video)]
	public class VideoPlayerGetIsPrepared : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Value")]
		public FsmBool isPrepared;

		[Tooltip("Event sent if content is prepared")]
		public FsmEvent isPreparedEvent;

		[Tooltip("Event sent if content is not yet prepared")]
		public FsmEvent isNotPreparedEvent;

		[Tooltip("Execute action everyframe. Events are however sent discretly, only when changes occurs")]
		public bool everyframe;

		private GameObject go;

		private VideoPlayer _vp;

		private int _isPrepared;

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
