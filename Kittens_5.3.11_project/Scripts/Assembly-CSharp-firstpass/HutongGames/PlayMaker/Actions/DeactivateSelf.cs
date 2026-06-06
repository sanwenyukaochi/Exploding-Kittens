namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Deactivate the GameObject that owns the FSM.")]
	public class DeactivateSelf : FsmStateAction
	{
		[Tooltip("Seconds to wait before deactivating. Can be useful to let other actions finish first. E.g. a fade-out effect.\nNOTE: If you use a delay and the FSM switches away from this state before it is finished, the GameObject will not be deactivated.")]
		public FsmFloat delay;

		[Tooltip("Ignore any time scaling.")]
		public FsmBool realTime;

		private float elapsedTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoDeactivateSelf()
		{
		}
	}
}
