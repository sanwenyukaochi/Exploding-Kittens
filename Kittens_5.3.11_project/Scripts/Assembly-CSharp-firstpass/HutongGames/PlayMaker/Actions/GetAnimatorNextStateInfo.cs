using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the next State information on a specified layer")]
	public class GetAnimatorNextStateInfo : FsmStateActionAnimatorBase
	{
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's name.")]
		public FsmString name;

		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's name Hash. Obsolete in Unity 5, use fullPathHash or shortPathHash instead, nameHash will be the same as shortNameHash for legacy")]
		public FsmInt nameHash;

		[UIHint(UIHint.Variable)]
		[Tooltip("The full path hash for this state.")]
		public FsmInt fullPathHash;

		[UIHint(UIHint.Variable)]
		[Tooltip("The name Hash. Does not include the parent layer's name")]
		public FsmInt shortPathHash;

		[Tooltip("The layer's tag hash")]
		[UIHint(UIHint.Variable)]
		public FsmInt tagHash;

		[Tooltip("Is the state looping. All animations in the state must be looping")]
		[UIHint(UIHint.Variable)]
		public FsmBool isStateLooping;

		[Tooltip("The Current duration of the state. In seconds, can vary when the State contains a Blend Tree ")]
		[UIHint(UIHint.Variable)]
		public FsmFloat length;

		[UIHint(UIHint.Variable)]
		[Tooltip("The integer part is the number of time a state has been looped. The fractional part is the % (0-1) of progress in the current loop")]
		public FsmFloat normalizedTime;

		[Tooltip("The integer part is the number of time a state has been looped. This is extracted from the normalizedTime")]
		[UIHint(UIHint.Variable)]
		public FsmInt loopCount;

		[Tooltip("The progress in the current loop. This is extracted from the normalizedTime")]
		[UIHint(UIHint.Variable)]
		public FsmFloat currentLoopProgress;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnActionUpdate()
		{
		}

		private void GetLayerInfo()
		{
		}
	}
}
