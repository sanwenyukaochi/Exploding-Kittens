namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Perform a raycast into the scene using screen coordinates and stores the results. Use Ray Distance to set how close the camera must be to pick the object. NOTE: Uses the MainCamera!")]
	public class ScreenPick : FsmStateAction
	{
		[Tooltip("A Vector3 screen position. Commonly stored by other actions.")]
		public FsmVector3 screenVector;

		[Tooltip("X position on screen.")]
		public FsmFloat screenX;

		[Tooltip("Y position on screen.")]
		public FsmFloat screenY;

		[Tooltip("Are the supplied screen coordinates normalized (0-1), or in pixels.")]
		public FsmBool normalized;

		[Tooltip("The length of the ray to use.")]
		[RequiredField]
		public FsmFloat rayDistance;

		[Tooltip("Store whether the ray hit an object in a Bool Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidPickObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the hit Game Object in a Game Object Variable.")]
		public FsmGameObject storeGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the world position of the hit point in a Vector3 Variable.")]
		public FsmVector3 storePoint;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the normal of the hit point in a Vector3 Variable.\nNote, this is a direction vector not a rotation. Use Look At Direction to rotate a GameObject to this direction.")]
		public FsmVector3 storeNormal;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance to the hit point.")]
		public FsmFloat storeDistance;

		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers. Set a number then select layers.")]
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
