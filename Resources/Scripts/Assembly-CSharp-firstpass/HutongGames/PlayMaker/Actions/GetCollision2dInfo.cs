namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets info on the last collision 2D event and store in variables. See Unity and PlayMaker docs on Unity 2D physics.")]
	public class GetCollision2dInfo : FsmStateAction
	{
		[Tooltip("Get the GameObject hit.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject gameObjectHit;

		[Tooltip("Get the enabled state collision. if false, collision had no effect, like when using the PlatformEffector2D component set to one way")]
		[UIHint(UIHint.Variable)]
		public FsmBool enabled;

		[Tooltip("Get the relative velocity of the collision.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 relativeVelocity;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the relative speed of the collision. Useful for controlling reactions. E.g., selecting an appropriate sound fx.")]
		public FsmFloat relativeSpeed;

		[Tooltip("Get the world position of the collision contact. Useful for spawning effects etc.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 contactPoint;

		[Tooltip("Get the 2d world position of the collision contact. Useful for spawning effects etc.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 contactPoint2d;

		[Tooltip("Get the collision normal vector. Useful for aligning spawned effects etc.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 contactNormal;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the 2d collision normal vector. Useful for aligning spawned effects etc.")]
		public FsmVector2 contactNormal2d;

		[UIHint(UIHint.Variable)]
		[Tooltip("The number of separate shaped regions in the collider.")]
		public FsmInt shapeCount;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the name of the physics 2D material of the colliding GameObject. Useful for triggering different effects. Audio, particles...")]
		public FsmString physics2dMaterialName;

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
