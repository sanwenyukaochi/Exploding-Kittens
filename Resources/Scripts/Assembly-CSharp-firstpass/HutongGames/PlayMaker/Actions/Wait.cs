namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Delays a State from finishing. Optionally send an event after the specified time. NOTE: Other actions continue running and can send events before this action finishes.")]
	public class Wait : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Time to wait in seconds.")]
		public FsmFloat time;

		[Tooltip("Event to send after the specified time.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale. E.g., if the game is paused using Scale Time.")]
		public bool realTime;

		private float startTime;

		private float timer;

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
