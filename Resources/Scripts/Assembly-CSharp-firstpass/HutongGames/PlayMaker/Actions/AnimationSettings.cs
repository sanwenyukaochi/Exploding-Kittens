using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Applies animation settings to the specified animation. Note: Settings are applied once, on entering the state, not continuously. Use\u00a0{{Set Animation Speed}},\u00a0{{Set Animation Time}}\u00a0etc. if you need to update those animation\u00a0settings every frame.\\nSee\u00a0<a href=\"https://docs.unity3d.com/Manual/AnimationScripting.html\" rel =\"nofollow\" target=\"_blank\">Unity Animation Docs</a>\u00a0for detailed descriptions of Wrap Mode, Blend Mode, Speed and Layer settings.")]
	public class AnimationSettings : BaseAnimationAction
	{
		[CheckForComponent(typeof(Animation))]
		[RequiredField]
		[Tooltip("A GameObject with an Animation Component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.Animation)]
		[Tooltip("The name of the animation. Use the browse button to select from animations on the Game Object (if available).")]
		public FsmString animName;

		[Tooltip("Set how the animation wraps (Loop, PingPong etc.). NOTE: Because of the way WrapMode is defined by Unity you cannot select Once, but Clamp is the same as Once.")]
		public WrapMode wrapMode;

		[Tooltip("How the animation is blended with other animations on the Game Object.")]
		public AnimationBlendMode blendMode;

		[Tooltip("Speed up or slow down the animation. 1 is normal speed, 0.5 is half speed...")]
		[HasFloatSlider(0f, 5f)]
		public FsmFloat speed;

		[Tooltip("You can play animations on different layers to combine them into a final animation. See the Unity Animation docs for more details.")]
		public FsmInt layer;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoAnimationSettings()
		{
		}
	}
}
