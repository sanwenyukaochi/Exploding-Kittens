using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the Sorting Layer of a SpriteRenderer component by Id (by id is faster than by name)")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class SetSpriteSortingLayerById : ComponentAction<SpriteRenderer>
	{
		[CheckForComponent(typeof(SpriteRenderer))]
		[RequiredField]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The sorting Layer Name")]
		[RequiredField]
		public FsmInt sortingLayerId;

		[Tooltip("If true, set the sorting layer to all children")]
		public FsmBool setAllSpritesInChildren;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
