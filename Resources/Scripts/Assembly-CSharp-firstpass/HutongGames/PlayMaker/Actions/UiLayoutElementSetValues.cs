using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets various properties of a UI Layout Element component.")]
	public class UiLayoutElementSetValues : ComponentAction<LayoutElement>
	{
		[Tooltip("The GameObject with the UI LayoutElement component.")]
		[CheckForComponent(typeof(LayoutElement))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The minimum width this layout element should have.")]
		[ActionSection("Values")]
		public FsmFloat minWidth;

		[Tooltip("The minimum height this layout element should have.")]
		public FsmFloat minHeight;

		[Tooltip("The preferred width this layout element should have before additional available width is allocated.")]
		public FsmFloat preferredWidth;

		[Tooltip("The preferred height this layout element should have before additional available height is allocated.")]
		public FsmFloat preferredHeight;

		[Tooltip("The relative amount of additional available width this layout element should fill out relative to its siblings.")]
		public FsmFloat flexibleWidth;

		[Tooltip("The relative amount of additional available height this layout element should fill out relative to its siblings.")]
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

		private void DoSetValues()
		{
		}
	}
}
