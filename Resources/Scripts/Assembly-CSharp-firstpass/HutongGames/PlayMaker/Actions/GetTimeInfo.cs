namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets various useful Time measurements.")]
	[ActionCategory(ActionCategory.Time)]
	public class GetTimeInfo : FsmStateAction
	{
		public enum TimeInfo
		{
			DeltaTime = 0,
			TimeScale = 1,
			SmoothDeltaTime = 2,
			TimeInCurrentState = 3,
			TimeSinceStartup = 4,
			TimeSinceLevelLoad = 5,
			RealTimeSinceStartup = 6,
			RealTimeInCurrentState = 7
		}

		[Tooltip("Info to get.")]
		public TimeInfo getInfo;

		[Tooltip("Store the time info in a float variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeValue;

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

		private void DoGetTimeInfo()
		{
		}
	}
}
