namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Easing Animation - Float")]
	[ActionCategory(ActionCategory.AnimateVariables)]
	public class EaseFloat : EaseFsmAction
	{
		[RequiredField]
		[Tooltip("The float value to ease from.")]
		public FsmFloat fromValue;

		[RequiredField]
		[Tooltip("The float value to ease to.")]
		public FsmFloat toValue;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Float Variable.")]
		public FsmFloat floatVariable;

		private bool finishInNextStep;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
