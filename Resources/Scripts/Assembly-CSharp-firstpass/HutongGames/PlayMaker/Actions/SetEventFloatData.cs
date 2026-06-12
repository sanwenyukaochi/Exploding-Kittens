namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Float data to send with the next event. Get the Event Data, along with sender information, using the {{Get Event Info}} action.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class SetEventFloatData : FsmStateAction
	{
		[Tooltip("The float value to send.")]
		public FsmFloat floatData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
