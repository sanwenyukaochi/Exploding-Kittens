using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Color Block of a UI Selectable component. Modifications will not be visible if transition is not ColorTint")]
	[ActionCategory(ActionCategory.UI)]
	public class UiSetColorBlock : ComponentAction<Selectable>
	{
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the UI Selectable component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The fade duration value. Leave as None for no effect")]
		public FsmFloat fadeDuration;

		[Tooltip("The color multiplier value. Leave as None for no effect")]
		public FsmFloat colorMultiplier;

		[Tooltip("The normal color value. Leave as None for no effect")]
		public FsmColor normalColor;

		[Tooltip("The pressed color value. Leave as None for no effect")]
		public FsmColor pressedColor;

		[Tooltip("The highlighted color value. Leave as None for no effect")]
		public FsmColor highlightedColor;

		[Tooltip("The disabled color value. Leave as None for no effect")]
		public FsmColor disabledColor;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private Selectable selectable;

		private ColorBlock _colorBlock;

		private ColorBlock originalColorBlock;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
