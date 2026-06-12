using UnityEngine;
using UnityEngine.Video;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Video)]
	[Tooltip("Get the size in pixels of a videoClip")]
	public class VideoClipGetSize : FsmStateAction
	{
		[CheckForComponent(typeof(VideoPlayer))]
		[Tooltip("The GameObject with as VideoPlayer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Or The video clip of the VideoPlayer. Leave to none, else gameObject is ignored")]
		[UIHint(UIHint.Variable)]
		public FsmObject orVideoClip;

		[Tooltip("The width of the VideoClip")]
		[UIHint(UIHint.Variable)]
		public FsmInt width;

		[Tooltip("The height of the VideoClip")]
		[UIHint(UIHint.Variable)]
		public FsmInt height;

		[UIHint(UIHint.Variable)]
		[Tooltip("The width and height of the VideoClip")]
		public FsmVector2 size;

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
