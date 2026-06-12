namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Delays a State from finishing by a random time. NOTE: Other actions continue running during this time.\nAfter the random time the specified Finish Event or FINISHED is sent.")]
	public class RandomWait : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Minimum amount of time to wait.")]
		public FsmFloat min;

		[RequiredField]
		[Tooltip("Maximum amount of time to wait.")]
		public FsmFloat max;

		[Tooltip("Event to send when timer is finished.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore time scale.")]
		public bool realTime;

		private float startTime;

		private float timer;

		private float time;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
