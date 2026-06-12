using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Adds an Animation Clip to a Game Object. Optionally trim the clip.")]
	public class AddAnimationClip : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Animation))]
		[Tooltip("The Game Object to add the Animation Clip to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The animation clip to add. NOTE: Make sure the clip is compatible with the object's hierarchy.")]
		[RequiredField]
		[ObjectType(typeof(AnimationClip))]
		public FsmObject animationClip;

		[RequiredField]
		[Tooltip("Optionally give the animation a new name. Can be used by other Animation actions.")]
		public FsmString animationName;

		[Tooltip("Optionally trim the animation by specifying a first and last frame.")]
		[ActionSection("Trimming")]
		public FsmInt firstFrame;

		[Tooltip("Set the last frame of the trimmed animation. 0 means no trimming.")]
		public FsmInt lastFrame;

		[Tooltip("Add a frame at the end of the trimmed clip that's the same as the first frame so it loops nicely.")]
		public FsmBool addLoopFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoAddAnimationClip()
		{
		}
	}
}
