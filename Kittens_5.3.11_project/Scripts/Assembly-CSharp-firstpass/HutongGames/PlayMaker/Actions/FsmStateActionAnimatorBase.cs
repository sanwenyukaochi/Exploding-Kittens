using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	public abstract class FsmStateActionAnimatorBase : ComponentAction<Animator>
	{
		public enum AnimatorFrameUpdateSelector
		{
			OnUpdate = 0,
			OnAnimatorMove = 1,
			OnAnimatorIK = 2
		}

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		[Tooltip("Select when to perform the action, during OnUpdate, OnAnimatorMove, OnAnimatorIK")]
		public AnimatorFrameUpdateSelector everyFrameOption;

		protected int IklayerIndex;

		public abstract void OnActionUpdate();

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void DoAnimatorMove()
		{
		}

		public override void DoAnimatorIK(int layerIndex)
		{
		}
	}
}
