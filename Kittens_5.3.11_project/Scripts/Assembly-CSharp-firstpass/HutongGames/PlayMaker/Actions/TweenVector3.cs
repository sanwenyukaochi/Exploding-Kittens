namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	[Tooltip("Tween a Vector3 variable using a custom easing function.")]
	public class TweenVector3 : TweenVariableBase<FsmVector3>
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
