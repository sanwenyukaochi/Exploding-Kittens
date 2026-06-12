namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds the closest object to the specified Game Object.\nOptionally filter by Tag and Visibility.")]
	public class FindClosest : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to measure from.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Tag)]
		[Tooltip("Only consider objects with this Tag. NOTE: It's generally a lot quicker to find objects with a Tag!")]
		public FsmString withTag;

		[Tooltip("If checked, ignores the object that owns this FSM.")]
		public FsmBool ignoreOwner;

		[Tooltip("Only consider objects visible to the camera.")]
		public FsmBool mustBeVisible;

		[Tooltip("Store the closest object.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance to the closest object.")]
		public FsmFloat storeDistance;

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

		private void DoFindClosest()
		{
		}
	}
}
