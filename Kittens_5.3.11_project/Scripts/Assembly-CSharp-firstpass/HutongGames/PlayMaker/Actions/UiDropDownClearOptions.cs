using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Clear the list of options in a UI Dropdown Component")]
	public class UiDropDownClearOptions : ComponentAction<Dropdown>
	{
		[Tooltip("The GameObject with the UI DropDown component.")]
		[RequiredField]
		[CheckForComponent(typeof(Dropdown))]
		public FsmOwnerDefault gameObject;

		private Dropdown dropDown;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
