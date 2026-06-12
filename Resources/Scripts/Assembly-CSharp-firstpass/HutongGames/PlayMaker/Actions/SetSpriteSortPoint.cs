using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Determines the position of the Sprite used for sorting the Renderer. Unity 2018.2 or higher.")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class SetSpriteSortPoint : ComponentAction<SpriteRenderer>
	{
		[CheckForComponent(typeof(SpriteRenderer))]
		[RequiredField]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Set the Sprite Sorting Point value")]
		[ObjectType(typeof(SpriteSortPoint))]
		public FsmEnum spriteSortPoint;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
