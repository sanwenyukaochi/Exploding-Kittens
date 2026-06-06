namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends Events based on the comparison of 2 Vector3 variables.")]
	[ActionCategory(ActionCategory.Logic)]
	public class Vector3Compare : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The first Vector3 variable.")]
		public FsmVector3 vector1;

		[Tooltip("The second Vector3 variable.")]
		[RequiredField]
		public FsmVector3 vector2;

		[RequiredField]
		[Tooltip("Tolerance for the Equal test (almost equal).")]
		public FsmFloat tolerance;

		[Tooltip("Event sent if Rect 1 equals Rect 2 (within Tolerance)")]
		public FsmEvent equal;

		[Tooltip("Event sent if Rect 1 does not equal Rect 2 (within Tolerance)")]
		public FsmEvent notEqual;

		[Tooltip("Repeat every frame. Useful if the variables are changing and you're waiting for a particular result.")]
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

		private void DoCompare()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
