using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Applies a jolt of force to a GameObject's position and wobbles it back to its initial position.")]
	[ActionCategory("iTween")]
	public class iTweenPunchPosition : iTweenFsmAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		[Tooltip("A vector punch range.")]
		[RequiredField]
		public FsmVector3 vector;

		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		public Space space;

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
