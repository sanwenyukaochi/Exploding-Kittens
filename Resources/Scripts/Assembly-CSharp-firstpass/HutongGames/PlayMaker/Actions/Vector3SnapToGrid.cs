namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Snap Vector3 coordinates to grid points.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3SnapToGrid : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Vector3 Variable to snap.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		[Tooltip("Grid Size.")]
		public FsmFloat gridSize;

		[Tooltip("Repeat every frame.")]
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

		private void DoSnapToGrid()
		{
		}
	}
}
