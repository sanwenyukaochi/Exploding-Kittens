namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Snap Vector2 coordinates to grid points.")]
	[ActionCategory(ActionCategory.Vector2)]
	public class Vector2SnapToGrid : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Vector2 Variable to snap.")]
		public FsmVector2 vector2Variable;

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
