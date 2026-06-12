using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set the Order in Layer of a SpriteRenderer component.")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class SetSpriteOrderInLayer : ComponentAction<SpriteRenderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(SpriteRenderer))]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The Order In Layer Value")]
		public FsmInt orderInLayer;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
