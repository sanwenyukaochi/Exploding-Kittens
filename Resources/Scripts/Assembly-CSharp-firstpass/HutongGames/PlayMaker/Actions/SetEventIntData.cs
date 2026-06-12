namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Int data to send with the next event. Get the Event Data, along with sender information, using the {{Get Event Info}} action.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SetEventIntData : FsmStateAction
	{
		[Tooltip("The int value to send.")]
		public FsmInt intData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
