using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Set the selected value (zero based index) of the UI Dropdown Component")]
	public class UiDropDownSetValue : ComponentAction<Dropdown>
	{
		[Tooltip("The GameObject with the UI DropDown component.")]
		[RequiredField]
		[CheckForComponent(typeof(Dropdown))]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The selected index of the dropdown (zero based index).")]
		public FsmInt value;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Dropdown dropDown;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void SetValue()
		{
		}
	}
}
