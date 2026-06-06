namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Rigid bodies 2D start sleeping when they come to rest. This action wakes up all rigid bodies 2D in the scene. E.g., if you Set Gravity 2D and want objects at rest to respond.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class WakeAllRigidBodies2d : FsmStateAction
	{
		[Tooltip("Repeat every frame. Note: This would be very expensive!")]
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

		private void DoWakeAll()
		{
		}
	}
}
