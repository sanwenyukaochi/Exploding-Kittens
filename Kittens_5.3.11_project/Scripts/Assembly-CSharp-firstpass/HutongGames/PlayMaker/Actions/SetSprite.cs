using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Sets a Sprite on a GameObject. Object must have a Sprite Renderer.")]
	public class SetSprite : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[CheckForComponent(typeof(SpriteRenderer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The source sprite of the UI Image component.")]
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
