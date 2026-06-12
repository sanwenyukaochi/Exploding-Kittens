using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Tween)]
	[Tooltip("Punches a GameObject's position, rotation, or scale\u00a0and springs back to starting state")]
	public class TweenPunch : TweenComponentBase<Transform>
	{
		public enum PunchType
		{
			Position = 0,
			Rotation = 1,
			Scale = 2
		}

		[Tooltip("Punch position, rotation, or scale.")]
		public PunchType punchType;

		[Tooltip("Punch magnitude.")]
		public FsmVector3 value;

		private Transform transform;

		private RectTransform rectTransform;

		private Vector3 startVector3;

		private Vector3 endVector3;

		private Quaternion startRotation;

		private Quaternion midRotation;

		private Quaternion endRotation;

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
