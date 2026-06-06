namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tween an integer variable using a custom easing function. NOTE: Tweening is performed on float values and then rounded to the integer value.")]
	[ActionCategory(ActionCategory.Tween)]
	public class TweenInt : TweenVariableBase<FsmInt>
	{
		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		protected override void DoTween()
		{
		}
	}
}
