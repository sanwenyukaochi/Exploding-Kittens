using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Get the video clip path in the project's assets. (readonly)")]
	public class VideoClipGetOriginalPath : FsmStateAction
	{
		[Tooltip("The GameObject with as VideoPlayer component.")]
		[CheckForComponent(typeof(VideoPlayer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Or The video clip of the VideoPlayer. Leave to none, else gameObject is ignored")]
		[UIHint(UIHint.Variable)]
		public FsmObject orVideoClip;

		[Tooltip("The video clip path in the project's assets")]
		[UIHint(UIHint.Variable)]
		public FsmString originalPath;

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
