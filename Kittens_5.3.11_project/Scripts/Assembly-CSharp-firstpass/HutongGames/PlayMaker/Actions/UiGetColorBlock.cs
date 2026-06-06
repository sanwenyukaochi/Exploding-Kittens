using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the Color Block of a UI Selectable component.")]
	public class UiGetColorBlock : ComponentAction<Selectable>
	{
		[RequiredField]
		[CheckForComponent(typeof(Selectable))]
		[Tooltip("The GameObject with the UI Selectable component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The fade duration value. Leave as None for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmFloat fadeDuration;

		[Tooltip("The color multiplier value. Leave as None for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmFloat colorMultiplier;

		[UIHint(UIHint.Variable)]
		[Tooltip("The normal color value. Leave as None for no effect")]
		public FsmColor normalColor;

		[UIHint(UIHint.Variable)]
		[Tooltip("The pressed color value. Leave as None for no effect")]
		public FsmColor pressedColor;

		[UIHint(UIHint.Variable)]
		[Tooltip("The highlighted color value. Leave as None for no effect")]
		public FsmColor highlightedColor;

		[Tooltip("The disabled color value. Leave as None for no effect")]
		[UIHint(UIHint.Variable)]
		public FsmColor disabledColor;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private Selectable selectable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
