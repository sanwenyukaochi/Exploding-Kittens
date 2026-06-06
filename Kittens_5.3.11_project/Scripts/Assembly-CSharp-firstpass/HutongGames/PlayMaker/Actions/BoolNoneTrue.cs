namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if all the Bool Variables are False.\nSend an event or store the result.")]
	public class BoolNoneTrue : FsmStateAction
	{
		[Tooltip("The Bool variables to check.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool[] boolVariables;

		[Tooltip("Event to send if none of the Bool variables are True.")]
		public FsmEvent sendEvent;

		[Tooltip("Store the result in a Bool variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoNoneTrue()
		{
		}
	}
}
