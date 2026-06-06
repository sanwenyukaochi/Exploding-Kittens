using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the color of a UI Graphic component. (E.g. UI Sprite)")]
	[ActionCategory(ActionCategory.UI)]
	public class UiGraphicGetColor : ComponentAction<Graphic>
	{
		[RequiredField]
		[Tooltip("The GameObject with the UI component.")]
		[CheckForComponent(typeof(Graphic))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("The Color of the UI component")]
		public FsmColor color;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Graphic uiComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetColorValue()
		{
		}
	}
}
