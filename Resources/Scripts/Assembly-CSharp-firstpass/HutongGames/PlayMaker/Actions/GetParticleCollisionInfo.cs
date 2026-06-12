namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets info on the last particle collision event. See Unity Particle System docs.")]
	[ActionCategory(ActionCategory.Physics)]
	public class GetParticleCollisionInfo : FsmStateAction
	{
		[Tooltip("Get the GameObject hit.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject gameObjectHit;

		public override void Reset()
		{
		}

		private void StoreCollisionInfo()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
