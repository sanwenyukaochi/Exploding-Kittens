using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the Sorting Layer name and/or Id of a of a SpriteRenderer component.")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class GetSpriteSortingLayer : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[CheckForComponent(typeof(SpriteRenderer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The sorting layer name")]
		[UIHint(UIHint.Variable)]
		public FsmString sortingLayerName;

		[UIHint(UIHint.Variable)]
		[Tooltip("The sorting layer id")]
		public FsmInt sortingLayerId;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
