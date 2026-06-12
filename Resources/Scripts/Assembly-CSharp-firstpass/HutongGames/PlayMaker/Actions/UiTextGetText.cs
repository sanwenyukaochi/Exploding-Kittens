using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the text value of a UI Text component.")]
	public class UiTextGetText : ComponentAction<Text>
	{
		[RequiredField]
		[CheckForComponent(typeof(Text))]
		[Tooltip("The GameObject with the UI Text component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The text value of the UI Text component.")]
		public FsmString text;

		[Tooltip("Runs every frame. Useful to animate values over time.")]
		public bool everyFrame;

		private Text uiText;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetTextValue()
		{
		}
	}
}
