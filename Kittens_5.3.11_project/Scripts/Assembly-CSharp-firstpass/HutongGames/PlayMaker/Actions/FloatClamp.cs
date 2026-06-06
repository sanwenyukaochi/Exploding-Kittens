namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Clamps the value of Float Variable to a Min/Max range.")]
	public class FloatClamp : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Float variable to clamp.")]
		public FsmFloat floatVariable;

		[Tooltip("The minimum value allowed.")]
		[RequiredField]
		public FsmFloat minValue;

		[Tooltip("The maximum value allowed.")]
		[RequiredField]
		public FsmFloat maxValue;

		[Tooltip("Repeat every frame. Useful if the float variable is changing.")]
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
