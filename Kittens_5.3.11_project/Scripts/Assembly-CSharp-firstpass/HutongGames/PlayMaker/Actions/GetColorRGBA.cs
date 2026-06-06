namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Get the RGBA channels of a Color Variable and store them in Float Variables.")]
	public class GetColorRGBA : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Color variable.")]
		public FsmColor color;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the red channel in a float variable.")]
		public FsmFloat storeRed;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the green channel in a float variable.")]
		public FsmFloat storeGreen;

		[Tooltip("Store the blue channel in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeBlue;

		[Tooltip("Store the alpha channel in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeAlpha;

		[Tooltip("Repeat every frame. Useful if the color variable is changing.")]
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

		private void DoGetColorRGBA()
		{
		}
	}
}
