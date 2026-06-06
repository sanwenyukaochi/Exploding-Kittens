namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Perform a Mouse Pick on a 2d scene and stores the results. Use Ray Distance to set how close the camera must be to pick the 2d object.")]
	public class MousePick2d : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Store if a GameObject was picked in a Bool variable. True if a GameObject was picked, otherwise false.")]
		public FsmBool storeDidPickObject;

		[Tooltip("Store the picked GameObject in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked point in a variable.")]
		public FsmVector2 storePoint;

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

		private void DoMousePick2d()
		{
		}
	}
}
