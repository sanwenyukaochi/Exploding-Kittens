using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the source image sprite of a UI Image component.")]
	public class UiImageSetSprite : ComponentAction<Image>
	{
		[Tooltip("The GameObject with the Image UI component.")]
		[CheckForComponent(typeof(Image))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The source sprite of the UI Image component.")]
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private Image image;

		private Sprite originalSprite;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetImageSourceValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
