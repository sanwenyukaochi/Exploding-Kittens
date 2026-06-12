namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Transforms a Position from a Game Object's local space to world space.")]
	public class TransformPoint : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object that defines local space.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("A local position vector.")]
		public FsmVector3 localPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the transformed position, now in world space, in a Vector3 Variable.")]
		[RequiredField]
		public FsmVector3 storeResult;

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

		private void DoTransformPoint()
		{
		}
	}
}
