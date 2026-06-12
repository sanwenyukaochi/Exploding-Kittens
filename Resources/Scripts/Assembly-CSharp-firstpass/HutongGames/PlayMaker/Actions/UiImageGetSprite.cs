using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the source image sprite of a UI Image component.")]
	public class UiImageGetSprite : ComponentAction<Image>
	{
		[RequiredField]
		[CheckForComponent(typeof(Image))]
		[Tooltip("The GameObject with the UI Image component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[ObjectType(typeof(Sprite))]
		[UIHint(UIHint.Variable)]
		[Tooltip("The source sprite of the UI Image component.")]
		public FsmObject sprite;

		private Image image;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetImageSourceValue()
		{
		}
	}
}
