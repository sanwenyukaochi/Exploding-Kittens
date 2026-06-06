namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	[Tooltip("Tween a Rect variable using a custom easing function.")]
	public class TweenRect : TweenVariableBase<FsmRect>
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
