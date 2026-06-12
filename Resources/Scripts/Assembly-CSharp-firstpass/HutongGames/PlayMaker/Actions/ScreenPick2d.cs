namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Perform a raycast into the 2d scene using screen coordinates and stores the results. Use Ray Distance to set how close the camera must be to pick the 2d object. NOTE: Uses the MainCamera!")]
	[ActionCategory(ActionCategory.Input)]
	public class ScreenPick2d : FsmStateAction
	{
		[Tooltip("A Vector3 screen position. Commonly stored by other actions.")]
		public FsmVector3 screenVector;

		[Tooltip("X position on screen.")]
		public FsmFloat screenX;

		[Tooltip("Y position on screen.")]
		public FsmFloat screenY;

		[Tooltip("Are the supplied screen coordinates normalized (0-1), or in pixels.")]
		public FsmBool normalized;

		[Tooltip("Store whether the Screen pick did pick a GameObject")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidPickObject;

		[Tooltip("Store the picked GameObject")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;

		[Tooltip("Store the picked position in world Space")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storePoint;

		[Tooltip("Pick only from these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

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

		private void DoScreenPick()
		{
		}
	}
}
