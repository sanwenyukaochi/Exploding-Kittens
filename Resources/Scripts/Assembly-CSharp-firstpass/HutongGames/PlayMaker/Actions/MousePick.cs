namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Perform a Mouse Pick on the scene from the Main Camera and stores the results. Use Ray Distance to set how close the camera must be to pick the object.")]
	[ActionCategory(ActionCategory.Input)]
	public class MousePick : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Set the length of the ray to cast from the Main Camera.")]
		public FsmFloat rayDistance;

		[Tooltip("Set Bool variable true if an object was picked, false if not.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidPickObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked GameObject.")]
		public FsmGameObject storeGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the point of contact.")]
		public FsmVector3 storePoint;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the normal at the point of contact.\nNote, this is a direction vector not a rotation. Use Look At Direction to rotate a GameObject to this direction.")]
		public FsmVector3 storeNormal;

		[Tooltip("Store the distance to the point of contact.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDistance;

		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
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

		private void DoMousePick()
		{
		}
	}
}
