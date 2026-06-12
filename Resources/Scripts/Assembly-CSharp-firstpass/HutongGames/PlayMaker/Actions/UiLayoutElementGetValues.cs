using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets various properties of a UI Layout Element component.")]
	public class UiLayoutElementGetValues : ComponentAction<LayoutElement>
	{
		[Tooltip("The GameObject with the UI LayoutElement component.")]
		[CheckForComponent(typeof(LayoutElement))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[ActionSection("Values")]
		[Tooltip("Is this element use Layout constraints")]
		[UIHint(UIHint.Variable)]
		public FsmBool ignoreLayout;

		[UIHint(UIHint.Variable)]
		[Tooltip("The minimum width enabled state")]
		public FsmBool minWidthEnabled;

		[UIHint(UIHint.Variable)]
		[Tooltip("The minimum width this layout element should have.")]
		public FsmFloat minWidth;

		[Tooltip("The minimum height enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool minHeightEnabled;

		[Tooltip("The minimum height this layout element should have.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat minHeight;

		[UIHint(UIHint.Variable)]
		[Tooltip("The preferred width enabled state")]
		public FsmBool preferredWidthEnabled;

		[Tooltip("The preferred width this layout element should have before additional available width is allocated.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat preferredWidth;

		[Tooltip("The preferred height enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool preferredHeightEnabled;

		[Tooltip("The preferred height this layout element should have before additional available height is allocated.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat preferredHeight;

		[Tooltip("The flexible width enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool flexibleWidthEnabled;

		[Tooltip("The relative amount of additional available width this layout element should fill out relative to its siblings.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat flexibleWidth;

		[Tooltip("The flexible height enabled state")]
		[UIHint(UIHint.Variable)]
		public FsmBool flexibleHeightEnabled;

		[Tooltip("The relative amount of additional available height this layout element should fill out relative to its siblings.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat flexibleHeight;

		[Tooltip("Repeats every frame")]
		[ActionSection("Options")]
		public bool everyFrame;

		private LayoutElement layoutElement;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValues()
		{
		}
	}
}
