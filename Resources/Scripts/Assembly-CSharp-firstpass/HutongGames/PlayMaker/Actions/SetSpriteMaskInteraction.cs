using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Set the mode under which the sprite will interact with the masking system.")]
	public class SetSpriteMaskInteraction : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[CheckForComponent(typeof(SpriteRenderer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(SpriteMaskInteraction))]
		[Tooltip("Set the Mask Interactions of the SpriteRenderer component.")]
		public FsmEnum spriteMaskInteraction;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
