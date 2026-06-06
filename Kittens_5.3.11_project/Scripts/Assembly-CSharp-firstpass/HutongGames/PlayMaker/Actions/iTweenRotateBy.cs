using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Multiplies supplied values by 360 and rotates a GameObject by calculated amount over time.")]
	[ActionCategory("iTween")]
	public class iTweenRotateBy : iTweenFsmAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		[Tooltip("A vector that will multiply current GameObjects rotation.")]
		[RequiredField]
		public FsmVector3 vector;

		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		[Tooltip("For the shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		public Space space;

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
