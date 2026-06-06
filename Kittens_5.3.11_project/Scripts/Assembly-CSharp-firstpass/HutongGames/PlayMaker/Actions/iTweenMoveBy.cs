using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("iTween")]
	[Tooltip("Adds the supplied vector to a GameObject's position.")]
	public class iTweenMoveBy : iTweenFsmAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		[RequiredField]
		[Tooltip("The vector to add to the GameObject's position.")]
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

		[Tooltip("For a target the GameObject will look at.")]
		public FsmGameObject lookAtObject;

		[Tooltip("For a target the GameObject will look at.")]
		public FsmVector3 lookAtVector;

		[Tooltip("For the time in seconds the object will take to look at either the 'looktarget' or 'orienttopath'. 0 by default")]
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
