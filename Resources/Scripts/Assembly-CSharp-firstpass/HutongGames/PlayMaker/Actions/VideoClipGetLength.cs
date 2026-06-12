using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Get the length of the video clip in seconds. (readonly)")]
	public class VideoClipGetLength : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Or the video clip of the VideoPlayer. Leave to none, else gameObject is ignored")]
		[UIHint(UIHint.Variable)]
		public FsmObject orVideoClip;

		[Tooltip("The length of the video clip in seconds")]
		[UIHint(UIHint.Variable)]
		public FsmFloat length;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject go;

		private VideoPlayer _vp;

		private VideoClip _vc;

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

		private void GetVideoClip()
		{
		}
	}
}
