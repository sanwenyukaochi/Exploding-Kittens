using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Gets the source image sprite of a SpriteRenderer component.")]
	public class GetSprite : ComponentAction<SpriteRenderer>
	{
		[CheckForComponent(typeof(SpriteRenderer))]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(Sprite))]
		[RequiredField]
		[Tooltip("The source sprite of the SpriteRenderer component.")]
		[UIHint(UIHint.Variable)]
		public FsmObject sprite;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void ExecuteAction()
		{
		}
	}
}
