namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the sorting depth of subsequent GUI elements.")]
	public class SetGUIDepth : FsmStateAction
	{
		[Tooltip("See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/GUI-depth.html\">GUI.Depth</a>.")]
		[RequiredField]
		public FsmInt depth;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
