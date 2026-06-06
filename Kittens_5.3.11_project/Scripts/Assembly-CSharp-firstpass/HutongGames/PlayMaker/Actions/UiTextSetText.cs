using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the text value of a UI Text component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiTextSetText : ComponentAction<Text>
	{
		[CheckForComponent(typeof(Text))]
		[RequiredField]
		[Tooltip("The GameObject with the UI Text component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The text of the UI Text component.")]
		[UIHint(UIHint.TextArea)]
		public FsmString text;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Text uiText;

		private string originalString;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetTextValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
