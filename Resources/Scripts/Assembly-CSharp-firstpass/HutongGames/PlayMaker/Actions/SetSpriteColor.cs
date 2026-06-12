using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the color of a sprite renderer")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class SetSpriteColor : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[RequiredField]
		[CheckForComponent(typeof(SpriteRenderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Set the Color of the SpriteRenderer component")]
		public FsmColor color;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the red channel")]
		public FsmFloat red;

		[Tooltip("Set the green channel")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat green;

		[Tooltip("Set the blue channel")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat blue;

		[Tooltip("Set the alpha channel")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat alpha;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private Color originalColor;

		private Color newColor;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void SetColor()
		{
		}

		public override void OnExit()
		{
		}
	}
}
