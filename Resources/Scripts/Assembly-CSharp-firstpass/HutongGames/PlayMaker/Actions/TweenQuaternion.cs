using HutongGames.PlayMaker.TweenEnums;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tween a Quaternion variable using a custom easing function.")]
	[ActionCategory(ActionCategory.Tween)]
	public class TweenQuaternion : TweenVariableBase<FsmQuaternion>
	{
		[DisplayOrder(1)]
		[Tooltip("Type of interpolation. Linear is faster but looks worse if the rotations are far apart.")]
		public RotationInterpolation interpolation;

		protected override object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		protected override void DoTween()
		{
		}
	}
}
