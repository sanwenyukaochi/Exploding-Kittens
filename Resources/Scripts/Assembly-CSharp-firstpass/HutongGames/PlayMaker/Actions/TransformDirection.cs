namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Transforms a Direction from a Game Object's local space to world space.")]
	[ActionCategory(ActionCategory.Transform)]
	public class TransformDirection : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object that defines local space.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("A direction vector in the object's local space.")]
		[RequiredField]
		public FsmVector3 localDirection;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the transformed direction vector, now in world space, in a Vector3 Variable.")]
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

		private void DoTransformDirection()
		{
		}
	}
}
