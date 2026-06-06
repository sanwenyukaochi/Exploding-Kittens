namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the String data to send with the next event. Get the Event Data, along with sender information, using the {{Get Event Info}} action.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SetEventStringData : FsmStateAction
	{
		[Tooltip("The string value to send.")]
		public FsmString stringData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
