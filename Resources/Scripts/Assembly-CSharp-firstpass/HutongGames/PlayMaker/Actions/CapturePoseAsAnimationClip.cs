using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animation)]
	[Tooltip("Captures the current pose of a hierarchy as an animation clip.\n\nUseful to blend from an arbitrary pose (e.g. a rag-doll death) back to a known animation (e.g. idle).")]
	public class CapturePoseAsAnimationClip : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject root of the hierarchy to capture.")]
		[CheckForComponent(typeof(Animation))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Capture position keys.")]
		public FsmBool position;

		[Tooltip("Capture rotation keys.")]
		public FsmBool rotation;

		[Tooltip("Capture scale keys.")]
		public FsmBool scale;

		[UIHint(UIHint.Variable)]
		[RequiredField]
		[Tooltip("Store the result in an Object variable of type AnimationClip.")]
		[ObjectType(typeof(AnimationClip))]
		public FsmObject storeAnimationClip;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoCaptureAnimationClip()
		{
		}

		private void CaptureTransform(Transform transform, string path, AnimationClip clip)
		{
		}

		private void CapturePosition(Transform transform, string path, AnimationClip clip)
		{
		}

		private void CaptureRotation(Transform transform, string path, AnimationClip clip)
		{
		}

		private void CaptureScale(Transform transform, string path, AnimationClip clip)
		{
		}

		private void SetConstantCurve(AnimationClip clip, string childPath, string propertyPath, float value)
		{
		}
	}
}
