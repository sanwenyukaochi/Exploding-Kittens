namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.StateMachine)]
	[Tooltip("Gets the Vector3 data from the last Event.")]
	public class GetEventVector3Data : FsmStateAction
	{
		[Tooltip("Store the vector3 data in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 getVector3Data;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
