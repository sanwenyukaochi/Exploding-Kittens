using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Get the position of the Sprite used for sorting the Renderer.")]
	public class GetspriteSortPoint : ComponentAction<SpriteRenderer>
	{
		[CheckForComponent(typeof(SpriteRenderer))]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(SpriteSortPoint))]
		[Tooltip("Get the Sprite Sorting Point value")]
		public FsmEnum spriteSortPoint;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
