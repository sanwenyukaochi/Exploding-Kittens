namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Clamps the Magnitude of Vector3 Variable.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3ClampMagnitude : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The Vector3 variable to clamp.")]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Tooltip("Clamp to this max length.")]
		[RequiredField]
		public FsmFloat maxLength;

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

		private void DoVector3ClampMagnitude()
		{
		}
	}
}
