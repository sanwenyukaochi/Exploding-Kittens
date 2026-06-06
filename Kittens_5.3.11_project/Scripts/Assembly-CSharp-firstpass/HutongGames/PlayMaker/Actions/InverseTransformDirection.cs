namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Transforms a Direction from world space to a Game Object's local space. The opposite of TransformDirection.")]
	public class InverseTransformDirection : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The game object that defines local space.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The direction in world space.")]
		public FsmVector3 worldDirection;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Vector3 Variable.")]
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

		private void DoInverseTransformDirection()
		{
		}
	}
}
