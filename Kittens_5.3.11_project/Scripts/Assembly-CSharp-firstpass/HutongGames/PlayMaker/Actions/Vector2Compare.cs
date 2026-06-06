namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the comparison of 2 Vector2 variables.")]
	public class Vector2Compare : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The first Vector2 variable.")]
		public FsmVector2 vector1;

		[Tooltip("The second Vector2 variable.")]
		[RequiredField]
		public FsmVector2 vector2;

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
