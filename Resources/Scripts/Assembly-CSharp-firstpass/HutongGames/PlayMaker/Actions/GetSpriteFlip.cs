using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Gets the Flips values of a of a SpriteRenderer component.")]
	public class GetSpriteFlip : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[RequiredField]
		[CheckForComponent(typeof(SpriteRenderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The X flip value")]
		[UIHint(UIHint.Variable)]
		public FsmBool x;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Y flip value")]
		public FsmBool y;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void GetFlip()
		{
		}
	}
}
