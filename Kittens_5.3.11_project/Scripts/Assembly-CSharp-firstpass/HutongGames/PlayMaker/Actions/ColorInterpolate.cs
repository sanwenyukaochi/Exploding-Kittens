namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Color)]
	[Tooltip("Interpolate through an array of Colors over a specified amount of Time.")]
	public class ColorInterpolate : FsmStateAction
	{
		[Tooltip("An array of colors. Set the number of colors, then set each color.")]
		[RequiredField]
		public FsmColor[] colors;

		[RequiredField]
		[Tooltip("How long it should take to interpolate through all the colors in the array.")]
		public FsmFloat time;

		[Tooltip("Store the interpolated color in a Color variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor storeColor;

		[Tooltip("Event to send when the interpolation finishes.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale. Useful when the game is paused.")]
		public bool realTime;

		private float startTime;

		private float currentTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
