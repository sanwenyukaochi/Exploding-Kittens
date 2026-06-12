using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.SpriteRenderer)]
	[Tooltip("Sets the Flips values of a of a SpriteRenderer component.")]
	public class SetSpriteFlip : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[RequiredField]
		[CheckForComponent(typeof(SpriteRenderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The X Flip value")]
		public FsmBool x;

		[Tooltip("The Y Flip value")]
		public FsmBool y;

		[Tooltip("Reset flip values when state exits")]
		public FsmBool resetOnExit;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private bool x_orig;

		private bool y_orig;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}

		private void FlipSprites()
		{
		}
	}
}
