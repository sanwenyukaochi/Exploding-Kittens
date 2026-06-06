using HutongGames.PlayMaker.TweenEnums;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	[ActionTarget(typeof(RectTransform), null, false)]
	[Tooltip("Tween the Width and Height of a UI object. NOTE: The size is also influenced by anchors!")]
	public class TweenUiSize : TweenComponentBase<RectTransform>
	{
		[Tooltip("Tween To/From Target Size.")]
		public TweenDirection tweenDirection;

		[Tooltip("Target Size. NOTE: The size is also influenced by anchors!")]
		public FsmVector2 targetSize;

		private RectTransform rectTransform;

		private Vector2 fromSize;

		private Vector2 toSize;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		protected override void DoTween()
		{
		}
	}
}
