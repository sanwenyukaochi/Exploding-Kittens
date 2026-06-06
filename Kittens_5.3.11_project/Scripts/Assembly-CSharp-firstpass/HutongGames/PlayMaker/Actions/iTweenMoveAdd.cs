using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("iTween")]
	[Tooltip("Translates a GameObject's position over time.")]
	public class iTweenMoveAdd : iTweenFsmAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		[Tooltip("A vector that will be added to a GameObjects position.")]
		[RequiredField]
		public FsmVector3 vector;

		[Tooltip("For the time in seconds the animation will take to complete.")]
		public FsmFloat time;

		[Tooltip("For the time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		[Tooltip("For the shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		[Tooltip("For the type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		public Space space;

		[Tooltip("For whether or not the GameObject will orient to its direction of travel. False by default.")]
		[ActionSection("LookAt")]
		public FsmBool orientToPath;

		[Tooltip("A target object the GameObject will look at.")]
		public FsmGameObject lookAtObject;

		[Tooltip("A target position the GameObject will look at.")]
		public FsmVector3 lookAtVector;

		[Tooltip("The time in seconds the object will take to look at either the Look At Target or Orient To Path. 0 by default")]
		public FsmFloat lookTime;

		[Tooltip("Restricts rotation to the supplied axis only. Just put there strinc like 'x' or 'xz'")]
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
