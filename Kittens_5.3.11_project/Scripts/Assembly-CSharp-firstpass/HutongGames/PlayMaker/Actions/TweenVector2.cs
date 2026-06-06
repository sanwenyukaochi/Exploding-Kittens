namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	[Tooltip("Tween a Vector2 variable using a custom easing function.")]
	public class TweenVector2 : TweenVariableBase<FsmVector2>
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
