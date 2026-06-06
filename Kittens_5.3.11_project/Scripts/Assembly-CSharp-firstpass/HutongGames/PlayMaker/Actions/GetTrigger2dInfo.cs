namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets info on the last Trigger 2d event and store in variables.  See Unity and PlayMaker docs on Unity 2D physics.")]
	public class GetTrigger2dInfo : FsmStateAction
	{
		[Tooltip("Get the GameObject hit.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject gameObjectHit;

		[Tooltip("The number of separate shaped regions in the collider.")]
		[UIHint(UIHint.Variable)]
		public FsmInt shapeCount;

		[UIHint(UIHint.Variable)]
		[Tooltip("Useful for triggering different effects. Audio, particles...")]
		public FsmString physics2dMaterialName;

		public override void Reset()
		{
		}

		private void StoreTriggerInfo()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
