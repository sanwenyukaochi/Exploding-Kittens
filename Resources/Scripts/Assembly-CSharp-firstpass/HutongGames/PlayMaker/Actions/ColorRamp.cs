namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sample a color on a continuous color gradient. Define the gradient with a color array. Use Sample At to get an interpolated color.\n\nFor example:\nIf Element 1 is black and Element 2 is red:\n<ul><li>Sample At 1 = black</li><li>Sample At 2 = red</li><li>Sample At 1.5 = dark red</li></ul>")]
	[ActionCategory(ActionCategory.Color)]
	public class ColorRamp : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Array of colors to defining the gradient.")]
		public FsmColor[] colors;

		[Tooltip("Point on the gradient to sample. Should be between 0 and the number of colors in the gradient.")]
		[RequiredField]
		public FsmFloat sampleAt;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the sampled color in a Color variable.")]
		public FsmColor storeColor;

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

		private void DoColorRamp()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
