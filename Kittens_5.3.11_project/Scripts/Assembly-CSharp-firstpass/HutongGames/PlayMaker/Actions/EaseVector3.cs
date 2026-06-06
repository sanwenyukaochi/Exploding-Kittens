namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Easing Animation - Vector3")]
	[ActionCategory(ActionCategory.AnimateVariables)]
	public class EaseVector3 : EaseFsmAction
	{
		[Tooltip("The Vector3 value to ease from.")]
		[RequiredField]
		public FsmVector3 fromValue;

		[Tooltip("The Vector3 value to ease to.")]
		[RequiredField]
		public FsmVector3 toValue;

		[Tooltip("Store the result in a Vector3 Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

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
