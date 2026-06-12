namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Transforms position from screen space into world space. NOTE: Uses the MainCamera!")]
	[ActionCategory(ActionCategory.Camera)]
	public class ScreenToWorldPoint : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Screen position as a vector.")]
		public FsmVector3 screenVector;

		[Tooltip("Screen X position in pixels or normalized. See Normalized.")]
		public FsmFloat screenX;

		[Tooltip("Screen X position in pixels or normalized. See Normalized.")]
		public FsmFloat screenY;

		[Tooltip("Distance into the screen in world units.")]
		public FsmFloat screenZ;

		[Tooltip("If true, X/Y coordinates are considered normalized (0-1), otherwise they are expected to be in pixels")]
		public FsmBool normalized;

		[Tooltip("Store the world position in a vector3 variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeWorldVector;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world X position in a float variable.")]
		public FsmFloat storeWorldX;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world Y position in a float variable.")]
		public FsmFloat storeWorldY;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world Z position in a float variable.")]
		public FsmFloat storeWorldZ;

		[Tooltip("Repeat every frame")]
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

		private void DoScreenToWorldPoint()
		{
		}
	}
}
