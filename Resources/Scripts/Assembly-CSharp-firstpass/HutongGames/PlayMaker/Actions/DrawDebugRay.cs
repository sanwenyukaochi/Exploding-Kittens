namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Draws a line in the Scene View from a Start point in a direction. Specify the start point as Game Objects or Vector3 world positions. If both are specified, position is used as a local offset from the Object's position.\n\nNotes:\n- Enable/disable Gizmos in the Game View toolbar.\n- Set how long debug lines are visible for in Preferences > Debugging.")]
	public class DrawDebugRay : FsmStateAction
	{
		[Tooltip("Draw ray from a GameObject.")]
		public FsmGameObject fromObject;

		[Tooltip("Draw ray from a world position, or local offset from GameObject if provided.")]
		public FsmVector3 fromPosition;

		[Tooltip("Direction vector of ray in world space.")]
		public FsmVector3 direction;

		[Tooltip("The color of the ray.")]
		public FsmColor color;

		public override void Awake()
		{
		}

		public override void Reset()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}
	}
}
