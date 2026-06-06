using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Get the mode under which the sprite will interact with the masking system.")]
	public class GetSpriteMaskInteraction : ComponentAction<SpriteRenderer>
	{
		[RequiredField]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[CheckForComponent(typeof(SpriteRenderer))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(SpriteMaskInteraction))]
		[Tooltip("Get the Mask Interactions of the SpriteRenderer component.")]
		public FsmEnum spriteMaskInteraction;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
