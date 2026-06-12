namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("NGUI")]
	[Tooltip("Gets the input values from a UIJoystick")]
	public class NguiGetJoystickInput : FsmStateAction
	{
		[Tooltip("The GameObject featuring the UIJoystick component.")]
		[CheckForComponent(typeof(UIJoystick))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("The Horyzontal and Vertical Input values")]
		public FsmVector2 input;

		[Tooltip("The pad angle")]
		[UIHint(UIHint.Variable)]
		public FsmFloat angle;

		[Tooltip("The pad input plus the  angle in the z value of the vector3. Use this for network synching, saves bandwidth")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 inputAndAngle;

		[Tooltip("Repeat every frame")]
		public bool everyFrame;

		private UIJoystick _joystick;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void doGetPadInputs()
		{
		}
	}
}
