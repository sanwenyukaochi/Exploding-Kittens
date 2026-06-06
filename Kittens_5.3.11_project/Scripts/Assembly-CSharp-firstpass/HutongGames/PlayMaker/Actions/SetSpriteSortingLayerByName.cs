using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the Sorting Layer of a SpriteRenderer component. by name")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class SetSpriteSortingLayerByName : ComponentAction<SpriteRenderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(SpriteRenderer))]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The sorting Layer Name")]
		public FsmString sortingLayerName;

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
