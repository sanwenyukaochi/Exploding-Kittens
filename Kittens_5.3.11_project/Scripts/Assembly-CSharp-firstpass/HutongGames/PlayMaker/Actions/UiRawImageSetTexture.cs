using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the texture of a UI RawImage component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiRawImageSetTexture : ComponentAction<RawImage>
	{
		[Tooltip("The GameObject with the UI RawImage component.")]
		[RequiredField]
		[CheckForComponent(typeof(RawImage))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The texture of the UI RawImage component.")]
		[RequiredField]
		public FsmTexture texture;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private RawImage _texture;

		private Texture _originalTexture;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
