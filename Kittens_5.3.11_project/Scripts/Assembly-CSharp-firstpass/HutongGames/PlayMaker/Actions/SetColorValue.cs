namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Sets the value of a Color Variable.")]
	public class SetColorValue : FsmStateAction
	{
		[Tooltip("The Color Variable to set.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		[RequiredField]
		[Tooltip("The color to set the variable to.")]
		public FsmColor color;

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

		private void DoSetColorValue()
		{
		}
	}
}
