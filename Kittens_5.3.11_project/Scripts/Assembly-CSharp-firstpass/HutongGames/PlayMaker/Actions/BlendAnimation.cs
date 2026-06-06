using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Blends an Animation towards a Target Weight over a specified Time.\nOptionally sends an Event when finished.")]
	[ActionCategory(ActionCategory.Animation)]
	public class BlendAnimation : BaseAnimationAction
	{
		[Tooltip("The GameObject to animate.")]
		[CheckForComponent(typeof(Animation))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the animation to blend.")]
		[UIHint(UIHint.Animation)]
		[RequiredField]
		public FsmString animName;

		[HasFloatSlider(0f, 1f)]
		[RequiredField]
		[Tooltip("Target weight to blend to.")]
		public FsmFloat targetWeight;

		[HasFloatSlider(0f, 5f)]
		[RequiredField]
		[Tooltip("Time it should take to reach the target weight (seconds).")]
		public FsmFloat time;

		[Tooltip("Event to send when the blend has finished.")]
		public FsmEvent finishEvent;

		private DelayedEvent delayedFinishEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoBlendAnimation(GameObject go)
		{
		}
	}
}
