namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a Float variable to its absolute value.")]
	[ActionCategory(ActionCategory.Math)]
	public class FloatAbs : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Float variable.")]
		public FsmFloat floatVariable;

		[Tooltip("Repeat every frame. Useful if the Float variable is changing.")]
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

		private void DoFloatAbs()
		{
		}
	}
}
