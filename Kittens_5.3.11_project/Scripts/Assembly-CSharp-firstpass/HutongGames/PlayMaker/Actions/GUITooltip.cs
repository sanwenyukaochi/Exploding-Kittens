namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Tooltip of the control the mouse is currently over and store it in a String Variable.")]
	[ActionCategory(ActionCategory.GUI)]
	public class GUITooltip : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the tooltip in a string variable.")]
		public FsmString storeTooltip;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
