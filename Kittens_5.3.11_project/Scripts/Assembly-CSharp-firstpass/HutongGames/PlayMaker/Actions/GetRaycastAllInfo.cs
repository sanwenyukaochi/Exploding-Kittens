namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last RaycastAll and store in array variables.")]
	public class GetRaycastAllInfo : FsmStateAction
	{
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the GameObjects hit in an array variable.")]
		public FsmArray storeHitObjects;

		[ArrayEditor(VariableType.Vector3, null, 0, 0, 65536)]
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of all ray hit point and store them in an array variable.")]
		public FsmArray points;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the normal at all hit points and store them in an array variable.")]
		[ArrayEditor(VariableType.Vector3, null, 0, 0, 65536)]
		public FsmArray normals;

		[ArrayEditor(VariableType.Float, null, 0, 0, 65536)]
		[Tooltip("Get the distance along the ray to all hit points and store them in an array variable.")]
		[UIHint(UIHint.Variable)]
		public FsmArray distances;

		[Tooltip("Repeat every frame. Warning, this could be affecting performances")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		private void StoreRaycastAllInfo()
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
