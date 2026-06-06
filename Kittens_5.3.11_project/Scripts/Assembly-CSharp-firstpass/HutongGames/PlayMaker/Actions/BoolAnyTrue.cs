namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if any of the given Bool Variables are True.")]
	public class BoolAnyTrue : FsmStateAction
	{
		[Tooltip("The Bool variables to check.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmBool[] boolVariables;

		[Tooltip("Event to send if any of the Bool variables are True.")]
		public FsmEvent sendEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool variable.")]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame while the state is active. Useful if you're waiting for any to be true.")]
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

		private void DoAnyTrue()
		{
		}
	}
}
