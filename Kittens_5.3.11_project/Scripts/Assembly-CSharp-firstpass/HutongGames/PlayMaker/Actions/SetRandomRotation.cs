namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets Random Rotation for a Game Object. Uncheck an axis to keep the current rotation around that axis.")]
	public class SetRandomRotation : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object to randomly rotate.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Use X axis.")]
		public FsmBool x;

		[Tooltip("Use Y axis.")]
		[RequiredField]
		public FsmBool y;

		[RequiredField]
		[Tooltip("Use Z axis.")]
		public FsmBool z;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoRandomRotation()
		{
		}
	}
}
