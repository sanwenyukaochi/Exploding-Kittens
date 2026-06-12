using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("iTween")]
	[Tooltip("Instantly changes a GameObject's position to a supplied destination then returns it to it's starting position over time.")]
	public class iTweenMoveFrom : iTweenFsmAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		[Tooltip("Move From a transform rotation.")]
		public FsmGameObject transformPosition;

		[Tooltip("The position the GameObject will animate from. If Transform Position is defined this is used as a local offset.")]
		public FsmVector3 vectorPosition;

		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		[Tooltip("Whether to animate in local or world space.")]
		public Space space;

		[Tooltip("Whether or not the GameObject will orient to its direction of travel. False by default.")]
		[ActionSection("LookAt")]
		public FsmBool orientToPath;

		[Tooltip("A target object the GameObject will look at.")]
		public FsmGameObject lookAtObject;

		[Tooltip("A target position the GameObject will look at.")]
		public FsmVector3 lookAtVector;

		[Tooltip("The time in seconds the object will take to look at either the Look At Target or Orient To Path. 0 by default")]
		public FsmFloat lookTime;

		[Tooltip("Restricts rotation to the supplied axis only.")]
		public AxisRestriction axis;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void DoiTween()
		{
		}
	}
}
