using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("GUILayout base action - don't use!")]
	public abstract class GUILayoutAction : FsmStateAction
	{
		[Tooltip("An array of layout options.See <a href=\"http://unity3d.com/support/documentation/ScriptReference/GUILayoutOption.html\" rel=\"nofollow\">GUILayoutOption</a>.")]
		public LayoutOption[] layoutOptions;

		private GUILayoutOption[] options;

		public GUILayoutOption[] LayoutOptions => null;

		public override void Reset()
		{
		}
	}
}
