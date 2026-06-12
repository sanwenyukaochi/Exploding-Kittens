using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Plays a Random Animation on a Game Object. You can set the relative weight of each animation to control how often they are selected.")]
	public class PlayRandomAnimation : BaseAnimationAction
	{
		[RequiredField]
		[Tooltip("Game Object to play the animation on.")]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Animation)]
		[Tooltip("An array of animations to pick randomly from.")]
		[CompoundArray("Animations", "Animation", "Weight")]
		public FsmString[] animations;

		[Tooltip("The relative probability of each animation being picked. E.g. a weight of 2 is twice a likely to be picked as a weight of 1.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		[Tooltip("How to treat previously playing animations.")]
		public PlayMode playMode;

		[Tooltip("Time taken to blend to this animation.")]
		[HasFloatSlider(0f, 5f)]
		public FsmFloat blendTime;

		[Tooltip("Event to send when the animation is finished playing. NOTE: Not sent with Loop or PingPong wrap modes!")]
		public FsmEvent finishEvent;

		[Tooltip("Event to send when the animation loops. If you want to send this event to another FSM use Set Event Target. NOTE: This event is only sent with Loop and PingPong wrap modes.")]
		public FsmEvent loopEvent;

		[Tooltip("Stop playing the animation when this state is exited.")]
		public bool stopOnExit;

		private AnimationState anim;

		private float prevAnimtTime;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoPlayRandomAnimation()
		{
		}

		private void DoPlayAnimation(string animName)
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}

		private void StopAnimation()
		{
		}
	}
}
