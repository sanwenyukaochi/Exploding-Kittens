using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tweens the color of the CanvasRenderer color associated with this Graphic.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiGraphicCrossFadeColor : ComponentAction<Graphic>
	{
		[Tooltip("The GameObject with a UI component.")]
		[CheckForComponent(typeof(Graphic))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Color target of the UI component. Leave to none and set the individual color values, for example to affect just the alpha channel")]
		public FsmColor color;

		[Tooltip("The red channel Color target of the UI component. Leave as None for no effect, else it overrides the color property")]
		public FsmFloat red;

		[Tooltip("The green channel Color target of the UI component. Leave as None for no effect, else it overrides the color property")]
		public FsmFloat green;

		[Tooltip("The blue channel Color target of the UI component. Leave as None for no effect, else it overrides the color property")]
		public FsmFloat blue;

		[Tooltip("The alpha channel Color target of the UI component. Leave as None for no effect, else it overrides the color property")]
		public FsmFloat alpha;

		[Tooltip("The duration of the tween")]
		public FsmFloat duration;

		[Tooltip("Should ignore Time.scale?")]
		public FsmBool ignoreTimeScale;

		[Tooltip("Should also Tween the alpha channel?")]
		public FsmBool useAlpha;

		private Graphic uiComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
