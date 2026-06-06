using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Sets the GUISkin used by GUI elements. Skins can be customized in the Unity editor. See unity docs: <a href=\"http://unity3d.com/support/documentation/Components/class-GUISkin.html\">GUISkin</a>.\n")]
	public class SetGUISkin : FsmStateAction
	{
		[Tooltip("The skin to use.")]
		[RequiredField]
		public GUISkin skin;

		[Tooltip("Apply this setting to all GUI calls, even in other scripts.")]
		public FsmBool applyGlobally;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
