namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Destroys the Owner of the FSM! Useful for spawned Prefabs that need to kill themselves, e.g., a projectile that explodes on impact.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class DestroySelf : FsmStateAction
	{
		[Tooltip("Seconds to wait before destroying the owner. Can be useful to let other actions finish first. E.g. a fade-out effect.\nNOTE: If you use a delay and the FSM switches away from this state before it is finished, the owner will not be destroyed!")]
		public FsmFloat delay;

		[Tooltip("Ignore any time scaling.")]
		public FsmBool realTime;

		[Tooltip("Detach children before destroying the Owner. This allows children to survive, useful to allow FX to fade out etc.")]
		public FsmBool detachChildren;

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

		private void DoDestroySelf()
		{
		}
	}
}
