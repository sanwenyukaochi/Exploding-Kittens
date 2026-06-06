namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Transforms position from world space to a Game Object's local space. The opposite of TransformPoint.")]
	[ActionCategory(ActionCategory.Transform)]
	public class InverseTransformPoint : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The game object that defines local space.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The world position vector.")]
		public FsmVector3 worldPosition;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the transformed vector in a Vector3 Variable.")]
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

		private void DoInverseTransformPoint()
		{
		}
	}
}
