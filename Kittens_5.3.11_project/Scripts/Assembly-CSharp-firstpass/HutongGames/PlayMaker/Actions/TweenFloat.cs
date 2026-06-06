namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	[Tooltip("Tween a float variable using a custom easing function.")]
	public class TweenFloat : TweenVariableBase<FsmFloat>
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
