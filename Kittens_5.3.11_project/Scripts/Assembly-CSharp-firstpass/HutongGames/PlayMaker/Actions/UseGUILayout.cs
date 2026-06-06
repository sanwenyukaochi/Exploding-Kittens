namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUILayout)]
	[Tooltip("Turn GUILayout on/off. If you don't use GUILayout actions you can get some performance back by turning GUILayout off. This can make a difference on iOS platforms.")]
	public class UseGUILayout : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Enable/disable GUILayout.")]
		public bool turnOffGUIlayout;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
