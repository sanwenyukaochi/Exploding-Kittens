namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Easing Animation - Color")]
	[ActionCategory(ActionCategory.AnimateVariables)]
	public class EaseColor : EaseFsmAction
	{
		[Tooltip("The Color value to ease from.")]
		[RequiredField]
		public FsmColor fromValue;

		[RequiredField]
		[Tooltip("The Color value to ease to.")]
		public FsmColor toValue;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Color Variable.")]
		public FsmColor colorVariable;

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
