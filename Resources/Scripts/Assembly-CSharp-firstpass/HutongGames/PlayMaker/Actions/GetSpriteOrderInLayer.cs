using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Get the Order in Layer of a SpriteRenderer component.")]
	public class GetSpriteOrderInLayer : ComponentAction<SpriteRenderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(SpriteRenderer))]
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
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
