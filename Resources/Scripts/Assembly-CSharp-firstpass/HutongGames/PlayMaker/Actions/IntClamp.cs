namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Clamp the value of an Integer Variable to a Min/Max range.")]
	[ActionCategory(ActionCategory.Math)]
	public class IntClamp : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The variable to clamp.")]
		[RequiredField]
		public FsmInt intVariable;

		[RequiredField]
		[Tooltip("Minimum allowed value.")]
		public FsmInt minValue;

		[RequiredField]
		[Tooltip("Maximum allowed value.")]
		public FsmInt maxValue;

		[Tooltip("Perform this action every frame.")]
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

		private void DoClamp()
		{
		}
	}
}
