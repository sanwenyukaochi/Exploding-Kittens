namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the value of an Enum Variable.")]
	[ActionCategory(ActionCategory.Enum)]
	public class SetEnumValue : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Enum Variable to set.")]
		public FsmEnum enumVariable;

		[MatchFieldType("enumVariable")]
		[Tooltip("The Enum value to set the variable to.")]
		public FsmEnum enumValue;

		[Tooltip("Repeat every frame.")]
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

		private void DoSetEnumValue()
		{
		}
	}
}
