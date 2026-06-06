using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Set Graphic Color. E.g. to set Sprite Color.")]
	public class UiGraphicSetColor : ComponentAction<Graphic>
	{
		[CheckForComponent(typeof(Graphic))]
		[RequiredField]
		[Tooltip("The GameObject with a UI component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Color of the UI component. Leave to none and set the individual color values, for example to affect just the alpha channel")]
		public FsmColor color;

		[Tooltip("The red channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat red;

		[Tooltip("The green channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat green;

		[Tooltip("The blue channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat blue;

		[Tooltip("The alpha channel Color of the UI component. Leave to none for no effect, else it overrides the color property")]
		public FsmFloat alpha;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private Graphic uiComponent;

		private Color originalColor;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetColorValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
