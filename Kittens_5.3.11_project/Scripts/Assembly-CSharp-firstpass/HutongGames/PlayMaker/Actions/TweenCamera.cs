using HutongGames.PlayMaker.TweenEnums;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tween common Camera properties.")]
	[ActionTarget(typeof(Camera), null, false)]
	[ActionCategory(ActionCategory.Tween)]
	public class TweenCamera : TweenComponentBase<Camera>
	{
		public enum CameraProperty
		{
			Aspect = 0,
			BackgroundColor = 1,
			FieldOfView = 2,
			OrthoSize = 3,
			PixelRect = 4,
			ViewportRect = 5
		}

		[Tooltip("Camera property to tween.")]
		public CameraProperty property;

		[Tooltip("Tween To/From values set below.")]
		public TweenDirection tweenDirection;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmColor targetColor;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmFloat targetFloat;

		[Tooltip("Context sensitive parameter. Depends on Property.")]
		public FsmRect targetRect;

		private Camera camera;

		private Color fromColor;

		private Color toColor;

		private float fromFloat;

		private float toFloat;

		private Rect fromRect;

		private Rect toRect;

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
