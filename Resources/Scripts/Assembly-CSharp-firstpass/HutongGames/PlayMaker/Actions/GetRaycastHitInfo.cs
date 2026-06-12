namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last Raycast and store in variables.")]
	public class GetRaycastHitInfo : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit by the last Raycast and store it in a variable.")]
		public FsmGameObject gameObjectHit;

		[Title("Hit Point")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the ray hit point and store it in a variable.")]
		public FsmVector3 point;

		[Tooltip("Get the normal at the hit point and store it in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 normal;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat distance;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		private void StoreRaycastInfo()
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
