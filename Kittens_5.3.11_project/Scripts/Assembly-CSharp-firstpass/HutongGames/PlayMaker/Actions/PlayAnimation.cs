using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Plays an Animation on a Game Object. You can add named animation clips to the object in the Unity editor, or with the Add Animation Clip action. NOTE: The game object must have an Animation component.")]
	public class PlayAnimation : BaseAnimationAction
	{
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The Game Object to play the animation on. NOTE: Must have an Animation Component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The name of the animation to play. Use the browse button to find animations on the specified Game Object.")]
		[UIHint(UIHint.Animation)]
		public FsmString animName;

		[Tooltip("Whether to stop all currently playing animations, or just the animations on the same layer as this animation.")]
		public PlayMode playMode;

		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time to cross-fade between animations (seconds).")]
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

		private void DoPlayAnimation()
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
