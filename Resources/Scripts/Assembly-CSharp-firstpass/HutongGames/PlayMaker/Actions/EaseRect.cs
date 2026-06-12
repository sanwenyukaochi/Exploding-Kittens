namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("AnimateVariables")]
	[Tooltip("Easing Animation - Rect.")]
	public class EaseRect : EaseFsmAction
	{
		[Tooltip("Ease from this Rect value.")]
		[RequiredField]
		public FsmRect fromValue;

		[RequiredField]
		[Tooltip("Ease to this Rect value.")]
		public FsmRect toValue;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the current value in a Rect Variable.")]
		public FsmRect rectVariable;

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
