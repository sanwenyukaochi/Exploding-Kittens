namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Converts Seconds to a String value representing the time.")]
	[HelpUrl("http://hutonggames.com/playmakerforum/index.php?topic=1711.0")]
	[ActionCategory(ActionCategory.Convert)]
	public class ConvertSecondsToString : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The seconds variable to convert.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat secondsVariable;

		[Tooltip("A string variable to store the time value.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		[RequiredField]
		[Tooltip("Format. 0 for days, 1 is for hours, 2 for minutes, 3 for seconds and 4 for milliseconds. 5 for total days, 6 for total hours, 7 for total minutes, 8 for total seconds, 9 for total milliseconds, 10 for two digits milliseconds. so {2:D2} would just show the seconds of the current time, NOT the grand total number of seconds, the grand total of seconds would be {8:F0}")]
		public FsmString format;

		[Tooltip("Repeat every frame. Useful if the seconds variable is changing.")]
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

		private void DoConvertSecondsToString()
		{
		}
	}
}
