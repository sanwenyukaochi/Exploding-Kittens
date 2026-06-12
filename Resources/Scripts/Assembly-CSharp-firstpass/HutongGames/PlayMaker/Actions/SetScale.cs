namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Scale of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	[ActionCategory(ActionCategory.Transform)]
	public class SetScale : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to scale.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Use stored Vector3 value, and/or set each axis below.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[Tooltip("Scale along the X axis (1 = normal).")]
		public FsmFloat x;

		[Tooltip("Scale along the Y axis (1 = normal).")]
		public FsmFloat y;

		[Tooltip("Scale along the Z axis (1 = normal).")]
		public FsmFloat z;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void DoSetScale()
		{
		}
	}
}
