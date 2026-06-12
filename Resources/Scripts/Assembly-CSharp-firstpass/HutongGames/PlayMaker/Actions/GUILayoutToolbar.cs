using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("GUILayout Toolbar. NOTE: Arrays must be the same length as NumButtons or empty.")]
	public class GUILayoutToolbar : GUILayoutAction
	{
		[Tooltip("The number of buttons in the toolbar")]
		public FsmInt numButtons;

		[Tooltip("Store the index of the selected button in an Integer Variable")]
		[UIHint(UIHint.Variable)]
		public FsmInt selectedButton;

		[Tooltip("Event to send when each button is pressed.")]
		public FsmEvent[] buttonEventsArray;

		[Tooltip("Image to use on each button.")]
		public FsmTexture[] imagesArray;

		[Tooltip("Text to use on each button.")]
		public FsmString[] textsArray;

		[Tooltip("Tooltip to use for each button.")]
		public FsmString[] tooltipsArray;

		[Tooltip("A named GUIStyle to use for the toolbar buttons. Default is Button.")]
		public FsmString style;

		[Tooltip("Update the content of the buttons every frame. Useful if the buttons are using variables that change.")]
		public bool everyFrame;

		private GUIContent[] contents;

		public GUIContent[] Contents => null;

		private void SetButtonsContent()
		{
		}

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnGUI()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
