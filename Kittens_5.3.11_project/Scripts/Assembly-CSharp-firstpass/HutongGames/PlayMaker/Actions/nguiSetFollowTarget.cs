namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("NGUI HUD Follow target")]
	[ActionCategory("Ngui Actions")]
	public class nguiSetFollowTarget : FsmStateAction
	{
		[UIHint(UIHint.Description)]
		public string notice;

		public override void OnEnter()
		{
		}
	}
}
