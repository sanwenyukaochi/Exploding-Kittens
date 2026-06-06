namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Float data from the last Event.")]
	[ActionCategory(ActionCategory.StateMachine)]
	public class GetEventFloatData : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the float data in a variable.")]
		public FsmFloat getFloatData;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
