using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Animate base action - DON'T USE IT!")]
	public abstract class CurveFsmAction : FsmStateAction
	{
		public enum Calculation
		{
			None = 0,
			AddToValue = 1,
			SubtractFromValue = 2,
			SubtractValueFromCurve = 3,
			MultiplyValue = 4,
			DivideValue = 5,
			DivideCurveByValue = 6
		}

		[Tooltip("Define animation time, scaling the curve to fit.")]
		public FsmFloat time;

		[Tooltip("If you define speed, your animation will speed up or slow down.")]
		public FsmFloat speed;

		[Tooltip("Delayed animation start.")]
		public FsmFloat delay;

		[Tooltip("Animation curve start from any time. If IgnoreCurveOffset is true the animation starts right after the state become entered.")]
		public FsmBool ignoreCurveOffset;

		[Tooltip("Optionally send an Event when the animation finishes.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		private float startTime;

		private float currentTime;

		private float[] endTimes;

		private float lastTime;

		private float deltaTime;

		private float delayTime;

		private float[] keyOffsets;

		protected AnimationCurve[] curves;

		protected Calculation[] calculations;

		protected float[] resultFloats;

		protected float[] fromFloats;

		protected float[] toFloats;

		private float[] distances;

		protected bool finishAction;

		protected bool isRunning;

		protected bool looping;

		private bool start;

		private float largestEndTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		protected void Init()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
