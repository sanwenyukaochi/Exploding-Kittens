using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Automatically adjust the GameObject position and rotation so that the AvatarTarget reaches the Match Position when the current animation state is at the specified progress.")]
	[ActionCategory(ActionCategory.Animator)]
	public class AnimatorMatchTarget : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with an Animator component.")]
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The body part that is used to match the target.")]
		public AvatarTarget bodyPart;

		[Tooltip("A GameObject target to match. Leave empty to use position instead.")]
		public FsmGameObject target;

		[Tooltip("A target position to match. If Target GameObject is set, this is used as an offset from the Target's position.")]
		public FsmVector3 targetPosition;

		[Tooltip("A rotation to match. If Target GameObject is set, this is used as an offset from the Target's rotation.")]
		public FsmQuaternion targetRotation;

		[Tooltip("The MatchTargetWeightMask Position XYZ weight")]
		public FsmVector3 positionWeight;

		[Tooltip("The MatchTargetWeightMask Rotation weight")]
		public FsmFloat rotationWeight;

		[Tooltip("Start time within the animation clip (0 - beginning of clip, 1 - end of clip)")]
		public FsmFloat startNormalizedTime;

		[Tooltip("End time within the animation clip (0 - beginning of clip, 1 - end of clip). Values greater than 1 trigger a match after a certain number of loops. Example: 2.3 means at 30% of 2nd loop.")]
		public FsmFloat targetNormalizedTime;

		[Tooltip("Should always be true")]
		public bool everyFrame;

		private GameObject cachedTarget;

		private Transform targetTransform;

		private MatchTargetWeightMask weightMask;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMatchTarget()
		{
		}
	}
}
