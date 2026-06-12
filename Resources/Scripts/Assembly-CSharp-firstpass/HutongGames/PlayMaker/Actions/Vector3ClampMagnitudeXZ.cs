namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Clamps the magnitude of Vector3 variable on the XZ Plane.")]
	public class Vector3ClampMagnitudeXZ : FsmStateAction
	{
		[Tooltip("The Vector3 variable to clamp.")]
		[UIHint(UIHint.Variable)]
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

		private void DoVector3ClampMagnitudeXZ()
		{
		}
	}
}
