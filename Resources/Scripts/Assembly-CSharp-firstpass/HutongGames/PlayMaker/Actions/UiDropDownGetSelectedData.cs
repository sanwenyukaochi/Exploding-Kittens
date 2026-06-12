using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the selected value (zero based index), sprite and text from a UI Dropdown Component")]
	[ActionCategory(ActionCategory.UI)]
	public class UiDropDownGetSelectedData : ComponentAction<Dropdown>
	{
		[RequiredField]
		[CheckForComponent(typeof(Dropdown))]
		[Tooltip("The GameObject with the UI DropDown component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The selected index of the dropdown (zero based index).")]
		[UIHint(UIHint.Variable)]
		public FsmInt index;

		[Tooltip("The selected text.")]
		[UIHint(UIHint.Variable)]
		public FsmString getText;

		[ObjectType(typeof(Sprite))]
		[Tooltip("The selected text.")]
		[UIHint(UIHint.Variable)]
		public FsmObject getImage;

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

		private void GetValue()
		{
		}
	}
}
