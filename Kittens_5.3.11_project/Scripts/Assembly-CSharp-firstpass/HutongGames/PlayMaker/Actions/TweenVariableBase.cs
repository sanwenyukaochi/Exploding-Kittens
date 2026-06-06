namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	public abstract class TweenVariableBase<T> : TweenPropertyBase<T> where T : NamedVariable
	{
		[RequiredField]
		[Tooltip("The variable to tween.")]
		[UIHint(UIHint.Variable)]
		public T variable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		protected override void InitTargets()
		{
		}
	}
}
