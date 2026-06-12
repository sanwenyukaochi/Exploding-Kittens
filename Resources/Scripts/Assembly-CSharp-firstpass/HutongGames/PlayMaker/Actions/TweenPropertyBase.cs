using HutongGames.PlayMaker.TweenEnums;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	public abstract class TweenPropertyBase<T> : TweenActionBase where T : NamedVariable
	{
		[Title("From")]
		[Tooltip("Setup where to tween from.")]
		public TargetValueOptions fromOption;

		[Tooltip("Tween from this value.")]
		[HideIf("HideFromValue")]
		public T fromValue;

		[Title("To")]
		[Tooltip("Setup where to tween to.")]
		public TargetValueOptions toOption;

		[HideIf("HideToValue")]
		[Tooltip("Tween to this value.")]
		public T toValue;

		public object StartValue { get; protected set; }

		public object EndValue { get; protected set; }

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		protected virtual void InitTargets()
		{
		}

		protected virtual object GetOffsetValue(object value, object offset)
		{
			return null;
		}

		protected override void DoTween()
		{
		}
	}
}
